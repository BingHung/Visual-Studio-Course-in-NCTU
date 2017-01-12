Module Module1

    Sub Main()

        Dim Influid As String = "R22"
        Dim State_A2 As Double = 2 ' for default

        Dim chokedcheck As Double = 0

        Dim L, Pin, D As Double
        Dim N, A, mr, dL, G, e As Double
        Dim Pout, dv, vavg, vout, vin, ftp, fsp, phi_tp, xin, xout, x, Pout_guess, h, vsp, vtp, visc_sp, visc_tp, visc_l, visc_g, xavg, v_l, v_g As Double
        Dim Resp, Retp As Double
        Dim Atp, Asp, Btp, Bsp As Double
        Dim Tin, Tout, Tpre As Double

        Pin = 1.248 'MPa   CDbl(HPCD.Pcond_sat.Text)
        mr = 0.048608 'CDbl(HPCD.MFR.Text)
        x = 0  '(HPCD.Xexpa_in.Text)
        Tpre = 321 'K CDbl(HPCD.Tcond_sat.Text) ' Tcond.sat for A2 expand '(K)

        L = 2.8 'm  CDbl(HPCD.Expa_TubeLength_txt.Text)
        D = 0.0023 'm   CDbl(HPCD.Expa_InnerD_txt.Text)
        e = 0.8 'CDbl(HPCD.Expa_Roughness_txt.Text)
        N = 10 '100

        dL = L / N
        A = Math.PI * 0.25 * (D ^ 2)
        G = mr / A


        If State_A2 = 2 Then
            ' CTS Condensor A3 => calculate subcooled => two phase            
            'XXXXXXXXXXXXXXXXXXXXXXXXXXXX   Subcooled Capillary XXXXXXXXXXXXXXXXXXXXXXXXXXXX

            Console.Write("State2 Log In , start to calculete subcooled")

            Dim TA3 As Double
            TA3 = 308.15 '(CDbl((HPCD.Texpa_in.Text))) '(K)

            Dim Tx, xzero, Px As Double
            Dim zeroL, zeroR As Double
            zeroL = 280.15
            zeroR = TA3
            Tx = (zeroL + zeroR) / 2

            Dim InitialState As New Fluid(Influid, "SI", "tp")
            InitialState.Properties(TA3, Pin)
            h = InitialState.i

            While (1)

                'Guess for state x = 0 

                Dim StateZero As New Fluid(Influid, "SI", "tp")
                StateZero.SatProp(Tx)

                xzero = (InitialState.i - StateZero.iL) / (StateZero.ifg)
                'MsgBox(xzero)

                If xzero < -0.001 Then
                    zeroR = Tx
                    Tx = (zeroL + zeroR) / 2
                ElseIf xzero > 0.001 Then
                    zeroL = Tx
                    Tx = (zeroL + zeroR) / 2
                End If

                'If Math.Abs(xzero) < 0.0001 Then Exit While
                If xzero > 0 And xzero < 0.001 Then Exit While
            End While
            'MsgBox(xzero)
            'MsgBox(Tx)

            ' Define stateZero , calaulte the tube length of one phase 
            ' Px = Pressure(Influid, "TS", "SI", CtoK(Tx), (InitialState.i / 1000))
            Px = Pressure(Influid, "Tliq", "SI", Tx)

            Dim dPzero, Re, u, f, Ls1, Ls2 As Double
            dPzero = (Pin - Px) * 10 ^ 6

            u = mr / A / InitialState.rho
            Re = G * D / InitialState.Visc
            f = 0.0014 + 0.125 * Re ^ (-0.32) '0.0791 * Re ^ -0.25
            'MsgBox(f)
            Ls1 = 2 * dPzero * D / (f * 4 * InitialState.rho * u ^ 2)
            Ls2 = L - Ls1

            Console.WriteLine("Total length : {0} , Subcooled Length : {1}", L, Ls1)
            Console.WriteLine("Subcooled f : {0} , subcooled final Tx : {1}", f, Tx)


            'MsgBox(Ls1)
            ' what i want to get are the 'Ls2' and ''the new initial state' 

            'XXXXXXXXXXXXXXXXXXXXXXXXXXXX   Two Phase Capillary XXXXXXXXXXXXXXXXXXXXXXXXXXXX

            Dim previous As New Fluid(Influid, "SI", "tp")
            previous.SatProp(Tx)

            x = 0
            'h = TwoPhaseProperties(previous.iL, previous.iG, x) '(previous.iG - previous.iL) * x + previous.iL

            'Dim E_sat As New Fluid(Influid, "si", "tp")
            'E_sat.SatProp(CtoK(ETsat.Text))

            Dim Lp, Rp, count As Double
            Lp = 0.101325 'E_sat.P '2
            Rp = Px 'CDbl(P2_3.Text) '2.13
            Pout = (Lp + Rp) / 2
            count = 1

            Pin = Px ' Re_state IC
            Tin = Tx ' Re_state IC
            'HPCD.ErrorMsg.Text = ""

            While (count < N)

                While (1)

                    '***********************************************************************************************************************
                    'Dim start As New Fluid("r22", "SI", "PH")
                    'start.CapillaryProp(Pin, previous.i / 1000)
                    Tin = Temperature(Influid, "PLIQ", "SI", Pin)

                    Dim start As New Fluid(Influid, "SI", "tp")
                    start.SatProp(Tin)

                    'Dim out As New Fluid("r22", "SI", "PH")
                    'out.CapillaryProp(Pout, previous.i / 1000)
                    Tout = Temperature(Influid, "PLIQ", "SI", Pout)

                    Dim out As New Fluid(Influid, "SI", "tp")
                    out.SatProp(Tout)
                    '***********************************************************************************************************************

                    xin = (h - start.iL) / start.ifg
                    xout = (h - out.iL) / out.ifg
                    xavg = xin '(xin + xout) / 2

                    vin = (1 - xin) * (1 / start.rhoL) + xin * (1 / start.rhoG) '1 / ((1 - xin) * (1 / start.rhoL) + xin * (1 / start.rhoG))
                    vout = (1 - xout) * (1 / out.rhoL) + xout * (1 / out.rhoG) '1 / ((1 - xout) * (1 / out.rhoL) + xout * (1 / out.rhoG))
                    dv = vout - vin 'vin - vout 'Math.Abs(vout - vin)
                    vavg = vin '(vout + vin) / 2
                    v_l = (1 / start.rhoL) '((1 / start.rhoL) + (1 / out.rhoL)) / 2
                    v_g = (1 / start.rhoG) '((1 / start.rhoG) + (1 / out.rhoG)) / 2
                    vsp = v_l
                    vtp = vavg

                    Dim s_out, h_out As Double
                    s_out = TwoPhaseProperties(out.sL, out.sG, xout)
                    h_out = TwoPhaseProperties(out.iL, out.iG, xout)

                    visc_l = start.viscL '(start.viscL + out.viscL) / 2
                    visc_g = start.viscG '(start.viscG + out.viscG) / 2
                    visc_sp = visc_l
                    visc_tp = ((1 - xavg) / visc_l + xavg / visc_g) ^ -1

                    Resp = G * D / visc_sp
                    Retp = G * D / visc_tp
                    fsp = 0.0014 + 0.125 * Resp ^ (-0.32) '0.0791 * Resp ^ (-0.25)

                    Bsp = 37530 / Resp
                    Btp = 37530 / Retp
                    Asp = 2.457 * Math.Log(1 / ((7 / Resp) ^ 0.9 + 0.27 * e / D))
                    Atp = 2.457 * Math.Log(1 / ((7 / Retp) ^ 0.9 + 0.27 * e / D))

                    Dim phi_tp_up, phi_tp_down, phi_tp_right As Double
                    phi_tp_up = (8 / Retp) ^ 12 + (Atp ^ 16 + Btp ^ 16) ^ (-3 / 2)
                    phi_tp_down = (8 / Resp) ^ 12 + (Asp ^ 16 + Bsp ^ 16) ^ (-3 / 2)
                    phi_tp_right = 1 + xavg * (v_g / v_l - 1)
                    phi_tp = (phi_tp_up / phi_tp_down) ^ (1 / 12) * phi_tp_right

                    'ftp = phi_tp * fsp * ((1 / start.rhoL) / (1 / vin))
                    ftp = phi_tp * fsp * (vsp / vtp)

                    Dim abstract As Double
                    abstract = (ftp * (vin / 2 / D) + (dv / dL)) * dL
                    'Pout_guess = -(G ^ 2 * (ftp * (vin / 2 / D) + (dv / dL))) * dL / (10 ^ 6) + Pin
                    Pout_guess = -(G ^ 2 * abstract) / (10 ^ 6) + Pin


                    MsgBox("Pout : " & Pout & "   Pout_guess : " & Pout_guess & "   fsp : " & fsp & "   ftp : " & ftp)
                    If (Pout_guess - Pout) > 0.01 Then
                        Rp = Pout
                        Pout = (Lp + Rp) / 2
                    ElseIf (Pout - Pout_guess) > 0.01 Then
                        Lp = Pout
                        Pout = (Lp + Rp) / 2
                    End If


                    If Math.Abs(Pout_guess - Pout) < 0.01 Then

                        'HPCD.ErrorMsg.Text = HPCD.ErrorMsg.Text & "Pout_guess = " & Pout_guess & " ,Pin = " & Pin & " ,Abstraction = " & abstract & " ,MFR = " & mr & " ,dP = " & (Pin - Pout) & " ,h = " & h_out & " ,s = " & s_out & vbNewLine & vbNewLine
                        If TwoPhaseProperties(out.sL, out.sG, xout) < chokedcheck Then
                            MsgBox("Choked")
                        End If
                        chokedcheck = TwoPhaseProperties(out.sL, out.sG, xout)
                        'MsgBox(TwoPhaseProperties(out.sL, out.sG, xout))
                        Exit While
                    End If

                End While
                ' MsgBox(Pout_guess)
                ' MsgBox(count)
                Pin = Pout_guess
                Lp = 0
                Rp = Pout_guess
                Pout = (Lp + Rp) / 2


                count = count + 1

            End While
            'MsgBox("from A3")
            '/****************************************************************************
            '** A performance Comparison Between Coiled and Straight Capillary Tubes Modification
            '**(mcoiled/mstraight) = 2.011(Dc/L)^0.0527*(di/L)^0.094

            '** di:         inside diameter of capillary tube (m)
            '** Dc:         coiled diameter(m)
            '** L = length Of the capillary tube
            '/****************************************************************************
            Dim Dc As Double = 0.13 'm   CDbl(HPCD.Expa_OuterD_txt.Text) '(m)
            'MsgBox(Pout_guess)
            Pout_guess = Pout_guess * (2.011 * (Dc / L) ^ 0.0527 * (D / L) ^ 0.094)

            'MsgBox(vout)
            'MsgBox(count)
            'MsgBox(Pout_guess)
            'HPCD.Pevap_sat.Text = Pout_guess.ToString("0.###")
            'HPCD.Xevap_in.Text = xout.ToString("0.###")


        ElseIf State_A2 = 1 Then
            ' CTS Condensor A2 => two phase only

            Dim previous As New Fluid(Influid, "SI", "tp")
            previous.SatProp(Tpre)
            h = (previous.iG - previous.iL) * x + previous.iL

            'Dim E_sat As New Fluid(Influid, "si", "tp")
            ' E_sat.SatProp(CtoK(ETsat.Text))

            Dim Lp, Rp, count, cplus As Double
            Lp = 0.101325 'E_sat.P '2
            Rp = 1.248 'CDbl(HPCD.Pcond_sat.Text) '2.13
            Pout = (Lp + Rp) / 2
            count = 1

            cplus = 0
            While (count < N)

                While (1)

                    '***********************************************************************************************************************
                    'Dim start As New Fluid("r22", "SI", "PH")
                    'start.CapillaryProp(Pin, previous.i / 1000)
                    Tin = Temperature(Influid, "PLIQ", "SI", Pin)

                    Dim start As New Fluid(Influid, "SI", "tp")
                    start.SatProp(Tin)

                    'Dim out As New Fluid("r22", "SI", "PH")
                    'out.CapillaryProp(Pout, previous.i / 1000)
                    Tout = Temperature(Influid, "PLIQ", "SI", Pout)

                    Dim out As New Fluid(Influid, "SI", "tp")
                    out.SatProp(Tout)
                    '***********************************************************************************************************************
                    xin = (h - start.iL) / start.ifg
                    xout = (h - out.iL) / out.ifg
                    vin = 1 / ((1 - xin) * (1 / start.rhoL) + xin * (1 / start.rhoG))
                    vout = 1 / ((1 - xout) * (1 / out.rhoL) + xout * (1 / out.rhoG))
                    dv = vout - vin 'vin - vout 'Math.Abs(vout - vin)


                    Resp = G * D / start.viscL
                    fsp = 0.0791 * Resp ^ (-0.25)

                    Retp = G * D / ((1 - xin) / start.viscL + xin / start.viscG) ^ -1

                    Bsp = 37530 / Resp
                    Btp = 37530 / Retp
                    Asp = 2.457 * Math.Log(1 / ((7 / Resp) ^ 0.9 + 0.27 * e / D))
                    Atp = 2.457 * Math.Log(1 / ((7 / Retp) ^ 0.9 + 0.27 * e / D))


                    phi_tp = (((8 / Retp) ^ 12 + (Atp ^ 16 + Btp ^ 16) ^ (-3 / 2)) / ((8 / Resp) ^ 12 + (Asp ^ 16 + Bsp ^ 16) ^ (-3 / 2))) ^ (1 / 12) * (1 + xin * ((1 / start.rhoG) / (1 / start.rhoL) - 1))

                    ftp = phi_tp * fsp * ((1 / start.rhoL) / (1 / vin))

                    Pout_guess = -(G ^ 2 * (ftp * (vin / 2 / D) + (dv / dL))) * dL / (10 ^ 6) + Pin


                    If (Pout_guess - Pout) > 0.01 Then
                        Lp = Pout
                        Pout = (Lp + Rp) / 2
                    ElseIf (Pout - Pout_guess) > 0.01 Then
                        Rp = Pout
                        Pout = (Lp + Rp) / 2
                    End If




                    If Math.Abs(Pout_guess - Pout) < 0.01 Then
                        Exit While
                    End If


                End While
                ' MsgBox(Pout_guess)
                ' MsgBox(count)
                Pin = Pout_guess
                Lp = 0
                Rp = Pout_guess
                Pout = (Lp + Rp) / 2

                ' If Math.Abs(Pout - 0.101325) < 0.1 Then
                'MsgBox("Error Capillary")
                'End If


                count = count + 1

            End While
            'MsgBox("from A2")
            'MsgBox(vout)
            'MsgBox(count)
            '/****************************************************************************
            '** A performance Comparison Between Coiled and Straight Capillary Tubes Modification
            '**(mcoiled/mstraight) = 2.011(Dc/L)^0.0527*(di/L)^0.094

            '** di:         inside diameter of capillary tube (m)
            '** Dc:         coiled diameter(m)
            '** L = length Of the capillary tube
            '/****************************************************************************
            Dim Dc As Double = 0.13 'CDbl(HPCD.Expa_OuterD_txt.Text) '(m)

            Pout_guess = Pout_guess * (2.011 * (Dc / L) ^ 0.0527 * (D / L) ^ 0.094)

            ' MsgBox(Pout_guess)
            'HPCD.Pevap_sat.Text = Pout_guess.ToString("0.###")
            'HPCD.Xevap_in.Text = xout.ToString("0.###")
        End If

    End Sub

    Public Function TwoPhaseProperties(ByVal f As Double, ByVal g As Double, ByVal x As Double) As Double
        If x < 0 Or x > 1 Then
            'Error Handler
        End If
        Return f * (1 - x) + g * x
    End Function

End Module
