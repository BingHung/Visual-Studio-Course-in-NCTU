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
        Me.Input = New System.Windows.Forms.TextBox()
        Me.txtmin = New System.Windows.Forms.TextBox()
        Me.txtmax = New System.Windows.Forms.TextBox()
        Me.ans = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Launch = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Input
        '
        Me.Input.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Input.Location = New System.Drawing.Point(12, 12)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(310, 33)
        Me.Input.TabIndex = 0
        Me.Input.Text = "Please Enter you number here !!"
        '
        'txtmin
        '
        Me.txtmin.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtmin.Location = New System.Drawing.Point(12, 107)
        Me.txtmin.Name = "txtmin"
        Me.txtmin.ReadOnly = True
        Me.txtmin.Size = New System.Drawing.Size(63, 40)
        Me.txtmin.TabIndex = 1
        '
        'txtmax
        '
        Me.txtmax.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtmax.Location = New System.Drawing.Point(259, 107)
        Me.txtmax.Name = "txtmax"
        Me.txtmax.ReadOnly = True
        Me.txtmax.Size = New System.Drawing.Size(63, 40)
        Me.txtmax.TabIndex = 2
        '
        'ans
        '
        Me.ans.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ans.Location = New System.Drawing.Point(138, 107)
        Me.ans.Name = "ans"
        Me.ans.ReadOnly = True
        Me.ans.Size = New System.Drawing.Size(63, 40)
        Me.ans.TabIndex = 3
        Me.ans.Text = "?"
        Me.ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(22, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "<"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label2.Location = New System.Drawing.Point(219, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "<"
        '
        'Launch
        '
        Me.Launch.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Launch.Location = New System.Drawing.Point(80, 188)
        Me.Launch.Name = "Launch"
        Me.Launch.Size = New System.Drawing.Size(179, 52)
        Me.Launch.TabIndex = 6
        Me.Launch.Text = "Launch"
        Me.Launch.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 255)
        Me.Controls.Add(Me.Launch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ans)
        Me.Controls.Add(Me.txtmax)
        Me.Controls.Add(Me.txtmin)
        Me.Controls.Add(Me.Input)
        Me.Name = "Form1"
        Me.Text = "Number Guessing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Input As TextBox
    Friend WithEvents txtmin As TextBox
    Friend WithEvents txtmax As TextBox
    Friend WithEvents ans As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Launch As Button
End Class
