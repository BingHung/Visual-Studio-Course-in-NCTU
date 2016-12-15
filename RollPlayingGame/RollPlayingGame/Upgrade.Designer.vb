<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Upgrade
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lv = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 96)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Upgrade !!!"
        '
        'Lv
        '
        Me.Lv.AutoSize = True
        Me.Lv.Font = New System.Drawing.Font("新細明體", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Lv.ForeColor = System.Drawing.Color.Red
        Me.Lv.Location = New System.Drawing.Point(115, 162)
        Me.Lv.Name = "Lv"
        Me.Lv.Size = New System.Drawing.Size(285, 96)
        Me.Lv.TabIndex = 2
        Me.Lv.Text = "Lv :  2"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.Location = New System.Drawing.Point(131, 290)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(267, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Continue"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Upgrade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lv)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Upgrade"
        Me.Text = "Upgrade"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lv As Label
    Friend WithEvents Button1 As Button
End Class
