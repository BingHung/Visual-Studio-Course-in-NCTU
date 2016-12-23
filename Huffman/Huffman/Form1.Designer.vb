<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Compress_btn = New System.Windows.Forms.Button()
        Me.Decompress_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Compress_btn
        '
        Me.Compress_btn.Font = New System.Drawing.Font("Georgia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compress_btn.Location = New System.Drawing.Point(12, 12)
        Me.Compress_btn.Name = "Compress_btn"
        Me.Compress_btn.Size = New System.Drawing.Size(451, 165)
        Me.Compress_btn.TabIndex = 0
        Me.Compress_btn.Text = "Compress"
        Me.Compress_btn.UseVisualStyleBackColor = True
        '
        'Decompress_btn
        '
        Me.Decompress_btn.Font = New System.Drawing.Font("Georgia", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Decompress_btn.Location = New System.Drawing.Point(12, 183)
        Me.Decompress_btn.Name = "Decompress_btn"
        Me.Decompress_btn.Size = New System.Drawing.Size(451, 193)
        Me.Decompress_btn.TabIndex = 1
        Me.Decompress_btn.Text = "Decompress"
        Me.Decompress_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(475, 388)
        Me.Controls.Add(Me.Decompress_btn)
        Me.Controls.Add(Me.Compress_btn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Compress_btn As Button
    Friend WithEvents Decompress_btn As Button
End Class
