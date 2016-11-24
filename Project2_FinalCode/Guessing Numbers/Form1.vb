Public Class Form1

    Dim keyin, guess, count, min, max, avg As Integer

    Private Sub Launch_Click(sender As Object, e As EventArgs) Handles Launch.Click

        keyin = Val(Input.Text)
        count = count + 1
        avg = (min + max) / 2

        If (keyin > avg And keyin < max) Then
            max = keyin
        ElseIf (keyin < avg And keyin > min) Then
            min = keyin
        ElseIf (keyin = avg) Then
            MsgBox(" Condratulation , you have tried " & count & " times")
            Close()
        End If

        txtmin.Text = min
        txtmax.Text = max
        Input.Text = "Try another number !!! "

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        count = 0
        min = 0
        max = 100
        Dim r As New Random
        guess = r.Next(1, 100)

        txtmin.Text = 0
        txtmax.Text = 100

    End Sub
End Class
