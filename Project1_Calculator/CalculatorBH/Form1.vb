Public Class Form1

    Dim FirstNumber, SecondNumber, AnswerNumber As Integer
    Dim ArithmeticProcess As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Show.Text = Show.Text & "0"

    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Show.Text = Show.Text & "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Show.Text = Show.Text & "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Show.Text = Show.Text & "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Show.Text = Show.Text & "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Show.Text = Show.Text & "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Show.Text = Show.Text & "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Show.Text = Show.Text & "7"
    End Sub

    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        FirstNumber = Val(Show.Text)
        Show.Text = ""
        ArithmeticProcess = "+"
    End Sub

    Private Sub btnsub_Click(sender As Object, e As EventArgs) Handles btnsub.Click
        FirstNumber = Val(Show.Text)
        Show.Text = ""
        ArithmeticProcess = "-"
    End Sub

    Private Sub btnmul_Click(sender As Object, e As EventArgs) Handles btnmul.Click
        FirstNumber = Val(Show.Text)
        Show.Text = ""
        ArithmeticProcess = "*"
    End Sub

    Private Sub btndiv_Click(sender As Object, e As EventArgs) Handles btndiv.Click
        FirstNumber = Val(Show.Text)
        Show.Text = ""
        ArithmeticProcess = "/"
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        SecondNumber = Val(Show.Text)
        If ArithmeticProcess = "+" Then
            AnswerNumber = FirstNumber + SecondNumber
        End If
        If ArithmeticProcess = "-" Then
            AnswerNumber = FirstNumber - SecondNumber
        End If
        If ArithmeticProcess = "*" Then
            AnswerNumber = FirstNumber * SecondNumber
        End If
        If ArithmeticProcess = "/" Then
            AnswerNumber = FirstNumber / SecondNumber
        End If
        Show.Text = AnswerNumber
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Show.Text = Show.Text & "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Show.Text = Show.Text & "9"
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Show.Clear()
    End Sub
End Class
