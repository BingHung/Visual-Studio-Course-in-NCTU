Module Module1

    Public Structure DryerAir

        Public T, RH, Pws, Pw, Pa, nw, mw As Double
        Public mPws, mPw, dm As Double

    End Structure

    Public Structure DryerCondition

        Public V, W_height, A, Patm, R, MolecularWeight As Double
        Public t As Double
        Public G, dmLM As Double
    End Structure

    Public DryerAirIn As New DryerAir
    Public DryerAirOut As New DryerAir
    Public DryerInitial As New DryerCondition

    Sub Main()

        DryerAirOut.T = 0


        DryerInitial.A = 1 '(m^3)
        DryerInitial.W_height = 0.1 '(m)
        DryerInitial.V = 0.9 '(m^3)
        DryerInitial.Patm = 101.325 '(kPa)
        DryerInitial.R = 8314.41 '(X)
        DryerInitial.MolecularWeight = 18 '(g/mol)

        DryerInitial.t = 600 '(s)

        '[1] Calculate DryerAirIn
        DryerAirIn.T = 298.15 '(K)
        DryerAirIn.RH = 0.1 '(X)

        DryerAirIn.Pws = Fun_Pws(DryerAirIn.T) '(Pa)
        DryerAirIn.Pw = DryerAirIn.Pws * DryerAirIn.RH '(Pa)
        DryerAirIn.Pa = DryerInitial.Patm - DryerAirIn.Pw / 1000 '(kPa)
        DryerAirIn.nw = DryerAirIn.Pw * DryerInitial.V / DryerInitial.R / DryerAirIn.T '(mole)
        DryerAirIn.mw = DryerAirIn.nw * DryerInitial.MolecularWeight '(g)

        '[2] Calculate G , rho 

        '   [2-1] guess RH_out
        DryerAirOut.RH = 0.5
        DryerAirOut.Pws = DryerAirIn.Pws '(Pa)
        DryerAirOut.Pw = DryerAirOut.Pws * DryerAirOut.RH '(Pa)
        DryerAirOut.nw = DryerAirOut.Pw * DryerInitial.V / DryerInitial.R / DryerAirIn.T '(mole)
        DryerAirOut.mw = DryerAirOut.nw * DryerInitial.MolecularWeight '(g)

        '   [2-2] Get G
        '[Not Correct ???] DryerInitial.G = (DryerAirOut.mw - DryerAirIn.mw) / 1000 / DryerInitial.t / DryerInitial.A '(kg/m^2.s)
        DryerInitial.G = (DryerAirOut.mw - DryerAirIn.mw) / 1000 / DryerInitial.t / DryerInitial.A '(kg/m^2.s)

        '   [2-3] Get mass transfer coef
        DryerAirIn.mPws = DryerAirIn.Pws / 0.62198 / DryerInitial.Patm / 1000
        DryerAirIn.mPw = DryerAirIn.Pw / 0.62198 / DryerInitial.Patm / 1000
        DryerAirIn.dm = DryerAirIn.mPws - DryerAirIn.mPw

        DryerAirOut.mPws = DryerAirOut.Pws / 0.62198 / DryerInitial.Patm / 1000
        DryerAirOut.mPw = DryerAirOut.Pw / 0.62198 / DryerInitial.Patm / 1000
        DryerAirOut.dm = DryerAirOut.mPws - DryerAirOut.mPw



        '[3] Calculate DryerAirOut




        'Console.WriteLine(Pws(298.15))
        Console.Read()

    End Sub


    Function Fun_Pws(T As Double) As Double

        ' The Unit of T =>  (K)

        Dim C8, C9, C10, C11, C12, C13 As Double
        C8 = -5800.2206
        C9 = 1.3914993
        C10 = -0.048640239
        C11 = 0.0000417676769
        C12 = -0.000000014452093
        C13 = 6.5459653

        Dim Pws_val As Double
        Pws_val = Math.Exp(C8 / T + C9 + C10 * T + C11 * T ^ 2 + C12 * T ^ 3 + C13 * Math.Log(T))

        Return Pws_val 'return unit (Pa)
    End Function

End Module
