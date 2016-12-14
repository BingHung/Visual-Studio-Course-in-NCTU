Public Class PlayAgain
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.LoadSettings()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub PlayAgain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelScore.Text = "Final Score : " + Str(Form1.Score)
    End Sub
End Class