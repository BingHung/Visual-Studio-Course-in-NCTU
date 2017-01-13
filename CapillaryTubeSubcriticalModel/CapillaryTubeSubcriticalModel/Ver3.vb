Module Ver3


    Public Structure Cap_Struct
        '(1) Inlet properties
        Public In_Temp As Double
        Public In_P, In_vf, In_vg, In_hf, In_hg, In_Viscf, In_Viscg As Double
        Public In_Velocty, In_Re, In_f As Double
        Public In_h, In_v, In_visc As Double
        Public In_x As Double
        '(2) Outlet Properties
        Public Out_Temp As Double
        Public Out_P, Out_vf, Out_vg, Out_hf, Out_hg, Out_Viscf, Out_Viscg As Double
        Public Out_Velocty, Out_Re, Out_f As Double
        Public Out_h, Out_v, Out_visc, Out_s As Double
        Public Out_x As Double
        '(3) Capillary Tube Geometry
        Public Geo_InnerDiameter, Geo_CrossSectionArea As Double
        '(4) Model Asumptions
        Public Influid As String
        Public MFR As Double
        Public w_dividedBy_A As Double
        Public fm As Double
        Public Vm As Double
        Public Section As Double
        Public SectionCout As Double
        Public TubeLength As Double
        Public dL As Double

    End Structure
    Public Cap As New Cap_Struct

    Public Function Cap_getx(ByVal w As Double, ByVal Area As Double, ByVal vg As Double, ByVal vf As Double, ByVal hg As Double, ByVal hf As Double, ByVal V1 As Double, ByVal h1 As Double) As Double
        Dim a, b, c As Double
        a = (vg + vf) ^ 2 * (w / Area) ^ 2 * 0.5
        b = 1000 * (hg - hf) + vf * (vg - vf) * (w / Area) ^ 2
        c = 1000 * (hf - h1) + (w / Area) ^ 2 * 0.5 * vf ^ 2 - V1 ^ 2 / 2
        Return (-b + (b ^ 2 - 4 * a * c) ^ 0.5) / (2 * a)
    End Function

    Public Function TwoPhaseProperties(ByVal f As Double, ByVal g As Double, ByVal x As Double) As Double
        If x < 0 Or x > 1 Then
            'Error Handler
        End If
        Return f * (1 - x) + g * x
    End Function


    Sub Cap_Ver3()

        Dim ChokedCheck As Double = 0
        Dim StopFlag As Double = 0

        ' Little tricks
        Cap.Out_x = 0
        Cap.SectionCout = 0
        Cap.Section = 10

        Cap.MFR = 0.015 '(w) kg/s
        Cap.Geo_InnerDiameter = 0.0023 '1.63 / 1000 '(ID) m
        Cap.Out_Temp = 308.040625 '40 + 273.15 'K
        Cap.TubeLength = 4 '1.93345257466 'm
        Cap.Influid = "R22"

        Cap.dL = Cap.TubeLength / Cap.Section
        Cap.Geo_CrossSectionArea = Math.PI * Cap.Geo_InnerDiameter ^ 2 / 4 '(A) m^2
        Cap.w_dividedBy_A = Cap.MFR / Cap.Geo_CrossSectionArea


        While (Cap.SectionCout < Cap.Section)

            ' In State
            Cap.In_Temp = Cap.Out_Temp ' ****************
            Dim Cap_In As New Fluid(Cap.Influid, "SI", "tp")
            Cap_In.SatProp(Cap.In_Temp)

            Cap.In_x = Cap.Out_x ' ****************

            Cap.In_P = Cap_In.P * 10 ^ 6  'Pa

            Cap.In_vf = 1 / Cap_In.rhoL 'm^3/kg
            Cap.In_vg = 1 / Cap_In.rhoG
            Cap.In_v = TwoPhaseProperties(Cap.In_vf, Cap.In_vg, Cap.In_x)

            Cap.In_Viscf = Cap_In.viscL  ' Pa.s  0.00018236 -> 0.00013867
            Cap.In_Viscg = Cap_In.viscG
            Cap.In_visc = TwoPhaseProperties(Cap.In_Viscf, Cap.In_Viscg, Cap.In_x)

            Cap.In_hf = Cap_In.iL / 1000 'kJ/kg
            Cap.In_hg = Cap_In.iG / 1000
            Cap.In_h = TwoPhaseProperties(Cap.In_hf, Cap.In_hg, Cap.In_x)

            Cap.In_Velocty = Cap.w_dividedBy_A * Cap.In_v
            Cap.In_Re = (Cap.In_Velocty * Cap.Geo_InnerDiameter / Cap.In_visc / Cap.In_v) ' There must be error cause the REFPROP visc value
            Cap.In_f = 0.33 / Cap.In_Re ^ 0.25

            Dim T2_L, T2_R, T2 As Double
            T2_L = 273.15 '273.15
            T2_R = Cap.In_Temp
            T2 = (T2_L + T2_R) / 2
            Cap.Out_Temp = T2

            While (1)
                ' Guess Out State
                'Cap.Out_Temp = 39.5 + 273.15 'K
                Dim Cap_Out As New Fluid(Cap.Influid, "SI", "tp")
                Cap_Out.SatProp(Cap.Out_Temp)

                Cap.Out_P = Cap_Out.P * 10 ^ 6  'Pa

                Cap.Out_vf = 1 / Cap_Out.rhoL 'm^3/kg
                Cap.Out_vg = 1 / Cap_Out.rhoG
                Cap.Out_Viscf = Cap_Out.viscL  ' Pa.s 0.00013867
                Cap.Out_Viscg = Cap_Out.viscG
                Cap.Out_hf = Cap_Out.iL / 1000 'kJ/kg
                Cap.Out_hg = Cap_Out.iG / 1000
                Cap.Out_x = Cap_getx(Cap.MFR, Cap.Geo_CrossSectionArea, Cap.Out_vg, Cap.Out_vf, Cap.Out_hg, Cap.Out_hf, Cap.In_Velocty, Cap.In_h)


                Cap.Out_v = TwoPhaseProperties(Cap.Out_vf, Cap.Out_vg, Cap.Out_x) 'm^3/kg
                Cap.Out_visc = TwoPhaseProperties(Cap.Out_Viscf, Cap.Out_Viscg, Cap.Out_x) 'Pa.s
                Cap.Out_h = TwoPhaseProperties(Cap.Out_hf, Cap.Out_hg, Cap.Out_x) 'kJ/kg           
                Cap.Out_s = TwoPhaseProperties(Cap_Out.sL, Cap_Out.sG, Cap.Out_x)


                Cap.Out_Velocty = Cap.w_dividedBy_A * Cap.Out_v
                Cap.Out_Re = (Cap.Out_Velocty * Cap.Geo_InnerDiameter / Cap.Out_visc / Cap.Out_v)
                Cap.Out_f = 0.33 / Cap.Out_Re ^ 0.25

                ' Average State
                Cap.fm = (Cap.In_f + Cap.Out_f) / 2
                Cap.Vm = (Cap.In_Velocty + Cap.Out_Velocty) / 2

                'Get Tube length
                Dim TubeLength As Double
                'TubeLength = ((Cap.In_P - Cap.Out_P) - Cap.w_dividedBy_A * (Cap.Out_Velocty - Cap.In_Velocty)) * Cap.Geo_InnerDiameter * 2 / Cap.fm / Cap.Vm / Cap.w_dividedBy_A
                'TubeLength = 0.2425
                TubeLength = Cap.dL

                ' Check P2 
                Dim P2_Iteration As Double
                P2_Iteration = Cap.In_P - Cap.w_dividedBy_A * (Cap.Out_Velocty - Cap.In_Velocty) - Cap.fm * TubeLength * Cap.Vm * Cap.w_dividedBy_A / Cap.Geo_InnerDiameter / 2


                'Console.WriteLine("P2 : {0}, P2_Iteration : {1} , T2 : {2}", Cap.Out_P, P2_Iteration, Cap.Out_Temp)
                StopFlag = StopFlag + 1
                If StopFlag > 25 Then
                    MsgBox("Diverge")
                    Exit While
                End If

                If (P2_Iteration / 1000 - Cap.Out_P / 1000) > 0.1 Then
                    T2_L = Cap.Out_Temp
                    Cap.Out_Temp = (T2_L + T2_R) / 2
                ElseIf (Cap.Out_P / 1000 - P2_Iteration / 1000) > 0.1 Then
                    T2_R = Cap.Out_Temp
                    Cap.Out_Temp = (T2_L + T2_R) / 2
                ElseIf Math.Abs(P2_Iteration / 1000 - Cap.Out_P / 1000) < 0.1 Then
                    'Console.WriteLine("Converge")
                    Console.WriteLine("Count : {0}", Cap.SectionCout)
                    Console.WriteLine("P2 : {0}, P2_Iteration : {1} , T2 : {2}", Cap.Out_P, P2_Iteration, Cap.Out_Temp)

                    If ChokedCheck > Cap.Out_s Then
                        Console.WriteLine("Error Choked")
                    End If
                    ChokedCheck = Cap.Out_s
                    Console.WriteLine("h2 : {0} , s2 : {1}", Cap.Out_h, Cap.Out_s)

                    Console.WriteLine()
                    Exit While
                End If

            End While

            StopFlag = 0
            Cap.SectionCout = Cap.SectionCout + 1
        End While
        MsgBox("Cap_Done")
        Console.Read()


    End Sub

End Module
