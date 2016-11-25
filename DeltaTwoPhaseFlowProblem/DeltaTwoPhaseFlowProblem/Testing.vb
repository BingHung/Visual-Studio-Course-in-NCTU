Module Testing




    Sub Test()
        Dim rhoL, rhoG, sigmaL, ViscL, ViscG As Double
        Dim mdotG, mdot, mdotL As Double
        Dim L, di, x As Double
        Dim Ac, G, ReG, ReL, fGO, fLO, A1, A2, A3, rho, Fr, We, phiLo, dPLO, dPf As Double

        rhoL = 998.3
        rhoG = 1.098
        sigmaL = 0.0661
        ViscL = 0.00046
        ViscG = 0.0000203
        mdotG = 0.003
        mdotL = 0.012
        L = 0.5
        di = 0.007


        mdot = mdotG + mdotL
        x = mdotG / mdot

        Console.WriteLine("length(m) : {0} " + vbNewLine + "diameter(m) : {1} " + vbNewLine + "quality : {2} " + vbNewLine + "mass flow rate(kg/s) : {3} " + vbNewLine + "Sigma(N/m) : {4}", L, di, x, mdot, sigmaL)

        Ac = Math.PI * di ^ 2 / 4
        G = mdot / Ac
        ReG = G * di / ViscG
        ReL = G * di / ViscL
        fGO = 0.0791 * ReG ^ -0.25
        fLO = 0.0791 * ReL ^ -0.25
        A1 = (1 - x) ^ 2 + x ^ 2 * (rhoL * fGO) / (rhoG * fLO)
        A2 = x ^ 0.78 * (1 - x) ^ 0.224
        A3 = (rhoL / rhoG) ^ 0.91 * (ViscG / ViscL) ^ 0.19 * (1 - ViscG / ViscL) ^ 0.7

        rho = 1 / (x / rhoG + (1 - x) / rhoL)
        Fr = G ^ 2 / (9.8 * di * rho ^ 2)
        We = G ^ 2 * di / (rho * sigmaL)
        phiLo = A1 + (3.24 * A2 * A3) / (Fr ^ 0.045 * We ^ 0.035)
        dPLO = 4 * L / di * fLO * G ^ 2 / 2 / rhoL
        dPf = phiLo * dPLO

        Console.Write("dPf(Pa) : {0}", dPf)
        Console.Read()

    End Sub


    Sub DeltaTest()
        Dim rhoL, rhoG, sigmaL, ViscL, ViscG As Double
        Dim mdot As Double
        Dim L, di, x As Double
        Dim Ac, G, ReG, ReL, fGO, fLO, A1, A2, A3, rho, Fr, We, phiLo, dPLO, dPf As Double


        rhoL = 998.3
        rhoG = 1.098
        sigmaL = 0.0661
        ViscL = 0.00046
        ViscG = 0.0000203
        'mdotG = 0.003
        'mdotL = 0.012
        L = 1.35 '0.5
        di = 4.95 / 1000 '0.007


        'mdot = mdotG + mdotL
        'x = mdotG / mdot

        mdot = 657 / 3600 / 10


        Ac = Math.PI * di ^ 2 / 4
        G = mdot / Ac
        ReG = G * di / ViscG
        ReL = G * di / ViscL
        fGO = 0.0791 * ReG ^ -0.25
        fLO = 0.0791 * ReL ^ -0.25
        A1 = (1 - x) ^ 2 + x ^ 2 * (rhoL * fGO) / (rhoG * fLO)
        A2 = x ^ 0.78 * (1 - x) ^ 0.224
        A3 = (rhoL / rhoG) ^ 0.91 * (ViscG / ViscL) ^ 0.19 * (1 - ViscG / ViscL) ^ 0.7

        rho = 1 / (x / rhoG + (1 - x) / rhoL)
        Fr = G ^ 2 / (9.8 * di * rho ^ 2)
        We = G ^ 2 * di / (rho * sigmaL)
        phiLo = A1 + (3.24 * A2 * A3) / (Fr ^ 0.045 * We ^ 0.035)
        dPLO = 4 * L / di * fLO * G ^ 2 / 2 / rhoL
        dPf = phiLo * dPLO

        Console.Write("dPf(Pa) : {0}", dPf)
        Console.Read()

    End Sub



End Module
