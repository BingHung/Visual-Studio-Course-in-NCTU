Public Class Form1

    Dim num As Integer = 0
    Dim Photo() As String = {"F1", "F2", "F3"}

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxWindowsMediaPlayer1.URL = "LTSnakeDemo01.MP4"
        AxWindowsMediaPlayer1.Ctlcontrols.stop()


        'For i As Integer = 0 To Photo.GetUpperBound(0)
        '    ImageList1.Images.Add(New Bitmap(Photo(i) & ".JPG"))
        'Next
        'ImageList1.ImageSize = New Size(250, 180)
        'ImageList1.ColorDepth = ColorDepth.Depth32Bit
        'ShowPic()

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        'PictureBox1.Image = Image.FromFile("F1.jpg")
        PictureBox1.Image = Image.FromFile(Photo(num) & ".jpg")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AxWindowsMediaPlayer1.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AxWindowsMediaPlayer1.Ctlcontrols.pause()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AxWindowsMediaPlayer1.Ctlcontrols.stop()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click
        WebBrowser1.Navigate(" https://www.youtube.com/watch?v=KZ2ghkDV--o&feature=youtu.be")
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        WebBrowser1.Navigate(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub
    Sub ShowPic()
        'PictureBox1.Image = ImageList1.Images(num)
    End Sub

    Private Sub btnPrev_Click(sender As Object, e As EventArgs) Handles btnPrev.Click
        num = num - 1
        If num < 0 Then
            num = 2
        End If

        PictureBox1.Image = Image.FromFile(Photo(num) & ".JPG")
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        num = num + 1
        If num > 2 Then
            num = 0
        End If

        PictureBox1.Image = Image.FromFile(Photo(num) & ".JPG")
    End Sub
End Class
