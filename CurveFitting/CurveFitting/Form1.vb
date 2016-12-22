Public Class Form1


    Dim A(4) As Double
    Dim B(4) As Double
    Dim input, output As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        A(0) = CDbl(x0.Text)
        A(1) = CDbl(x1.Text)
        A(2) = CDbl(x2.Text)
        A(3) = CDbl(x3.Text)

        B(0) = CDbl(f0.Text)
        B(1) = CDbl(f1.Text)
        B(2) = CDbl(f2.Text)
        B(3) = CDbl(f3.Text)

        input = CDbl(x.Text)
        output = 0

        'output = ((input - A(0)) * (input - A(1)) * (input - A(2)) * (input - A(3))) / ((A(0) - A(0)) * (A(0) - A(1)) * (A(0) - A(2)) * (A(0) - A(3)))

        Dim part1, part2, part3, part4 As Double

        part1 = ((input - A(1)) * (input - A(2)) * (input - A(3))) / ((A(0) - A(1)) * (A(0) - A(2)) * (A(0) - A(3))) * B(0)
        part2 = ((input - A(0)) * (input - A(2)) * (input - A(3))) / ((A(1) - A(0)) * (A(1) - A(2)) * (A(1) - A(3))) * B(1)
        part3 = ((input - A(0)) * (input - A(1)) * (input - A(3))) / ((A(2) - A(0)) * (A(2) - A(1)) * (A(2) - A(3))) * B(2)
        part4 = ((input - A(0)) * (input - A(1)) * (input - A(2))) / ((A(3) - A(0)) * (A(3) - A(1)) * (A(3) - A(2))) * B(3)

        output = part1 + part2 + part3 + part4
        fx.Text = output.ToString("#.##")


    End Sub

End Class
