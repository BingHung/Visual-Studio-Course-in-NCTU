Module Module1


    Sub Main()

        Dim DBT, W, RH As Double
        DBT = 13.83
        W = 0.0088399
        RH = Get_RH_from_DBT_W(DBT, W) '0.89
        Console.WriteLine(RH)
        Console.Read()


    End Sub

    Public Function Get_RH_from_DBT_W(ByVal DBT As Double, ByVal W As Double) As Double

        ' [SPEC]
        ' DBT (oC)
        ' W (kg/kg_dry air)

        Dim Pv, Ps, RH, Patm As Double
        Patm = 101.325
        Ps = Pressure("WATER.FLD", "Tliq", "SI", CtoK(DBT)) * 1000 '(kPa)
        Pv = (W / 0.62198) * Patm / (1 + W / 0.62198) '(kPa)
        RH = Pv / Ps

        Return RH

    End Function

End Module

