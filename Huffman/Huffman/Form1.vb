Public Class Form1
    Private Sub Compress_btn_Click(sender As Object, e As EventArgs) Handles Compress_btn.Click
        OpenFileDialog1.ShowDialog()
        Dim L As Long = FileSystem.FileLen(OpenFileDialog1.FileName)
        Dim B(0 To L - 1) As Byte
        FileSystem.FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Read)
        FileSystem.FileGet(1, B)
        FileSystem.FileClose(1)

        Dim CMP() As Byte = HuffmanCoding.CompressByteArray(B)

        FileSystem.FileOpen(1, OpenFileDialog1.FileName & ".cmp", OpenMode.Binary, OpenAccess.Write)
        FileSystem.FilePut(1, CMP)
        FileSystem.FileClose(1)

        MsgBox("Compress Done")

    End Sub

    Private Sub Decompress_btn_Click(sender As Object, e As EventArgs) Handles Decompress_btn.Click
        OpenFileDialog1.ShowDialog()
        Dim L As Long = FileSystem.FileLen(OpenFileDialog1.FileName)
        Dim B(0 To L - 1) As Byte
        FileSystem.FileOpen(1, OpenFileDialog1.FileName, OpenMode.Binary, OpenAccess.Read)
        FileSystem.FileGet(1, B)
        FileSystem.FileClose(1)

        Dim CMP() As Byte = HuffmanCoding.DecompressByteArray(B)

        FileSystem.FileOpen(1, OpenFileDialog1.FileName & ".jpg", OpenMode.Binary, OpenAccess.Write)
        FileSystem.FilePut(1, CMP)
        FileSystem.FileClose(1)

        MsgBox("Decompress Done")

    End Sub
End Class
