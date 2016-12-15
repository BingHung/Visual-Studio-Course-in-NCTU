Public Class Upgrade
    Private Sub Upgrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lv.Text = " Lv : " + Str(Form1.Level)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class