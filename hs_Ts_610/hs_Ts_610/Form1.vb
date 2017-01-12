Public Class Form1


    Public Function Ts_hs(ByVal Temp_K As Double) As Double

        Dim a, b, c, d, e, f, g, h, i, j, k, y, x As Double

        If (x > 50 Or x < 0) Then
            'error
        End If

        x = Temp_K

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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim T = 7.2 'oC
        MsgBox(Ts_hs(T))

    End Sub
End Class
