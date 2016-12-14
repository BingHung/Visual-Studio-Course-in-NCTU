Module Module1

    Sub Main()
        Dim Ts, isat As Double

        Console.Write("Please enter Ts : ")
        Ts = Console.ReadLine()
        Console.Write("Please enter isat : ")
        isat = Console.ReadLine()

        Console.WriteLine("Ts = {0} , is = {1}", Ts, Tstois(Ts))
        Console.WriteLine("Ts = {0} , is = {1}", Ts, Tstois2(Ts))
        Console.WriteLine("Ts = {0} , Ws = {1}", Ts, TstoWs(Ts))
        Console.WriteLine("Ts = {0} , isat = {1}", istoTs2(isat), isat)
        Console.Read()

    End Sub

    Function Tstois(ByVal Ts As Double) As Double
        Dim a, b, c, d, e, f, g, h, i, j, k, y, x As Double



        x = Ts
        a = 7.8054659
        b = 1.0903092
        c = 0.038844953
        d = 0.0027778215
        e = -0.000025391048
        f = -0.000002237666
        g = 0.000000025527341
        h = 0.00000000082928794
        i = -0.000000000008804055
        j = -0.000000000000098185946
        k = 0.000000000000001117715

        y = a + b * x + c * x ^ 2 + d * x ^ 3 + e * x ^ 4 + f * x ^ 5 + g * x ^ 6 + h * x ^ 7 + i * x ^ 8 + j * x ^ 9 + k * x ^ 10
        Return y

    End Function

    Function Tstois2(ByVal Ts As Double) As Double
        Dim a, b, c, d, e, f, g, h, i, j, k, y, x As Double

        x = Ts

        If (x > 50 Or x < 0) Then
            'error
        End If

        a = 9.474887
        b = 1.7045155
        c = 0.023445296
        d = 0.00038843238
        e = 0.000012841086
        f = -0.00000045177241
        g = 0.000000023166674
        h = -0.000000000643554
        i = 0.000000000011408721
        j = -0.00000000000011197705
        k = 0.00000000000000049410427

        y = a + b * x + c * x ^ 2 + d * x ^ 3 + e * x ^ 4 + f * x ^ 5 + g * x ^ 6 + h * x ^ 7 + i * x ^ 8 + j * x ^ 9 + k * x ^ 10
        Return y

    End Function

    Function istoTs2(ByVal isat As Double) As Double
        Dim a, b, c, d, e, f, g, h, i, j, k, y, x As Double

        x = isat

        If (x > 280 Or x < 9) Then
            'error
        End If

        a = -7.4658608
        b = 2.114808
        c = -0.61629354
        d = 0.43864504
        e = -0.094121714
        f = 0.010943011
        g = -0.0007868236
        h = 0.000035899762
        i = -0.0000010052862
        j = 0.000000015510775
        k = -0.00000000009758174

        y = a + b * x ^ 0.5 + c * x + d * x ^ 1.5 + e * x ^ 2 + f * x ^ 2.5 + g * x ^ 3 + h * x ^ 3.5 + i * x ^ 4 + j * x ^ 4.5 + k * x ^ 5
        Return y

    End Function


    Function TstoWs(ByVal Ts As Double) As Double

        Dim a, b, c, d, e, f, g, h, i, j, k, y, x As Double

        x = Ts

        If (x > 0.088 Or x < 0.003) Then
            'error
        End If

        a = 0.0037898538
        b = 0.00027729932
        c = 0.0000090170663
        d = 0.00000017328516
        e = 0.0000000023687104
        f = 0.000000000010699736
        g = -0.000000000000010535545
        h = 0.000000000000025175346
        i = -0.00000000000000067656523
        j = 8.7402708E-18
        k = -3.3684172E-20

        y = a + b * x + c * x ^ 2 + d * x ^ 3 + e * x ^ 4 + f * x ^ 5 + g * x ^ 6 + h * x ^ 7 + i * x ^ 8 + j * x ^ 9 + k * x ^ 10
        Return y

    End Function
End Module
