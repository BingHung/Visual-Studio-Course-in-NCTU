Module Module1



    Sub Main()
        DeltaTest()
        'Test()
        'TwoPhasePressuredrop()
    End Sub

    Sub TwoPhasePressuredrop()
        Dim D, L, X, mdot, Ts, Sigma As Double

        'Console.Write("Please enter length(m) : ")
        'L = Console.ReadLine()
        'Console.Write("Please enter tube diameter(m) : ")
        'D = Console.ReadLine()
        'Console.Write("Please enter quality : ")
        'X = Console.ReadLine()
        'Console.Write("Please enter mass flow rate(kg/s) : ")
        'mdot = Console.ReadLine()
        'Console.Write("Please enter Eavp temperature(k) : ")
        'Ts = Console.ReadLine()
        'Console.Write("Please enter Surface Tension(Sigma - N/m) : ")
        'Sigma = Console.ReadLine()

        L = 1.35
        D = 4.95 / 1000
        X = 0.2
        mdot = 657 / 3600 / 10
        Ts = 10
        Sigma = 0.0661



        ' Console.WriteLine("length(m) : {0} " + vbNewLine + "diameter(m) : {1} " + vbNewLine + "quality : {2} " + vbNewLine + "mass flow rate(kg/s) : {3} " + vbNewLine + "Tevap(k) : {4}" + vbNewLine + "Sigma(N/m) : {5}", L, D, X, mdot, Ts, Sigma)


        Dim Evap As New Fluid("R410A", "si", "tp")
        Evap.SatProp(Ts)

        Dim viscG, viscL, rhoL, rhoG As Double
        viscG = Evap.viscG
        viscL = Evap.viscL
        rhoL = Evap.rhoL
        rhoG = Evap.rhoG


        Dim Ac, G, ReG, ReL, fGO, fLO, A1, A2, A3, rho, Fr, We, PhiLo, dPLO, dPf As Double

        Ac = Math.PI * D ^ 2 / 4
        G = mdot / Ac
        ReG = G * D / viscG
        ReL = G * D / viscL
        fGO = 0.0791 * ReG ^ -0.25
        fLO = 0.0791 * ReL ^ -0.25
        A1 = (1 - X) ^ 2 + X ^ 2 * (rhoL * fGO) / (rhoG * fLO)
        A2 = X ^ 0.78 * (1 - X) ^ 0.224
        A3 = (rhoL / rhoG) ^ 0.91 * (viscG / viscL) ^ 0.19 * (1 - viscG / viscL) ^ 0.7
        rho = 1 / (X / rhoG + (1 - X) / rhoL)
        Fr = G ^ 2 / (9.8 * D * rho ^ 2)
        We = G ^ 2 * D / (rho * Sigma)
        PhiLo = A1 + (3.24 * A2 * A3) / (Fr ^ 0.045 * We ^ 0.035)
        dPLO = 4 * L / D * fLO * G ^ 2 / 2 / rhoL
        dPf = PhiLo * dPLO
        Console.Write("dPf : {0}", dPf)
        Console.Read()
    End Sub


End Module
