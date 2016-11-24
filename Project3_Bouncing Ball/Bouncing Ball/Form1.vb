Public Class Form1

    Dim MoveRight, MoveUp As Boolean
    Dim speed As Integer = 5
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick





        If MoveRight = True Then
            pokeball.Left += speed
        Else
            pokeball.Left -= speed
        End If

        If MoveUp = True Then
            pokeball.Top -= speed
        Else
            pokeball.Top += speed
        End If

        If pokeball.Left <= Me.ClientRectangle.Left Then
            MoveRight = True
            speedTunning()
        End If
        If pokeball.Left + pokeball.Width >= Me.ClientRectangle.Right Then
            MoveRight = False
            speedTunning()
        End If

        If pokeball.Top <= Me.ClientRectangle.Top Then
            MoveUp = False
            speedTunning()
        End If
        If pokeball.Top + pokeball.Height >= Me.ClientRectangle.Bottom Then
            MoveUp = True
            speedTunning()
        End If

    End Sub



    Sub speedTunning()
        Randomize()
        speed = Val(Rnd() * 10 + 5)
        SpeedDisplay.Text = speed
    End Sub
End Class
