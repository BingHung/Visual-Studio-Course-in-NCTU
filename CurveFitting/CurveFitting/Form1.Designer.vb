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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CurveFittingLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.x = New System.Windows.Forms.TextBox()
        Me.fx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.x0 = New System.Windows.Forms.TextBox()
        Me.f0 = New System.Windows.Forms.TextBox()
        Me.x1 = New System.Windows.Forms.TextBox()
        Me.f1 = New System.Windows.Forms.TextBox()
        Me.x2 = New System.Windows.Forms.TextBox()
        Me.f2 = New System.Windows.Forms.TextBox()
        Me.x3 = New System.Windows.Forms.TextBox()
        Me.f3 = New System.Windows.Forms.TextBox()
        Me.x4 = New System.Windows.Forms.TextBox()
        Me.f4 = New System.Windows.Forms.TextBox()
        Me.x5 = New System.Windows.Forms.TextBox()
        Me.f5 = New System.Windows.Forms.TextBox()
        Me.x6 = New System.Windows.Forms.TextBox()
        Me.f6 = New System.Windows.Forms.TextBox()
        Me.x7 = New System.Windows.Forms.TextBox()
        Me.f7 = New System.Windows.Forms.TextBox()
        Me.x8 = New System.Windows.Forms.TextBox()
        Me.f8 = New System.Windows.Forms.TextBox()
        Me.x9 = New System.Windows.Forms.TextBox()
        Me.f9 = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.CurveFittingLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(545, 502)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CurveFittingLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(537, 476)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "10 points"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CurveFittingLayoutPanel1
        '
        Me.CurveFittingLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CurveFittingLayoutPanel1.ColumnCount = 3
        Me.CurveFittingLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.CurveFittingLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.CurveFittingLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.CurveFittingLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CurveFittingLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f9, 2, 10)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x9, 1, 10)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f8, 2, 9)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x8, 1, 9)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f7, 2, 8)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x7, 1, 8)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f6, 2, 7)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x6, 1, 7)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f5, 2, 6)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x5, 1, 6)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f4, 2, 5)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x4, 1, 5)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f3, 2, 4)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x3, 1, 4)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f2, 2, 3)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x2, 1, 3)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f1, 2, 2)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x1, 1, 2)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.f0, 2, 1)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label4, 0, 1)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label3, 2, 0)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label2, 1, 0)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label7, 0, 4)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label5, 0, 2)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label6, 0, 3)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label8, 0, 5)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label9, 0, 6)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label10, 0, 7)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label11, 0, 8)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label12, 0, 9)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.Label13, 0, 10)
        Me.CurveFittingLayoutPanel1.Controls.Add(Me.x0, 1, 1)
        Me.CurveFittingLayoutPanel1.Location = New System.Drawing.Point(68, 9)
        Me.CurveFittingLayoutPanel1.Name = "CurveFittingLayoutPanel1"
        Me.CurveFittingLayoutPanel1.RowCount = 11
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909!))
        Me.CurveFittingLayoutPanel1.Size = New System.Drawing.Size(401, 459)
        Me.CurveFittingLayoutPanel1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(537, 476)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "15 points"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(8, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "i"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(90, 527)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "RUN"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'x
        '
        Me.x.Location = New System.Drawing.Point(228, 531)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(119, 22)
        Me.x.TabIndex = 3
        Me.x.Text = "3.0"
        '
        'fx
        '
        Me.fx.Location = New System.Drawing.Point(367, 531)
        Me.fx.Name = "fx"
        Me.fx.ReadOnly = True
        Me.fx.Size = New System.Drawing.Size(119, 22)
        Me.fx.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(11, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(322, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "f(x)"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "0"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(11, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "3"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "1"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(61, 137)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(11, 12)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "2"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(61, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(11, 12)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "4"
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(11, 12)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "5"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(61, 301)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 12)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "6"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "7"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(61, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 12)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "8"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 428)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(11, 12)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "9"
        '
        'x0
        '
        Me.x0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x0.Location = New System.Drawing.Point(149, 50)
        Me.x0.Name = "x0"
        Me.x0.Size = New System.Drawing.Size(100, 22)
        Me.x0.TabIndex = 15
        Me.x0.Text = "3.2"
        '
        'f0
        '
        Me.f0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f0.Location = New System.Drawing.Point(283, 50)
        Me.f0.Name = "f0"
        Me.f0.Size = New System.Drawing.Size(100, 22)
        Me.f0.TabIndex = 16
        Me.f0.Text = "22.0"
        '
        'x1
        '
        Me.x1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x1.Location = New System.Drawing.Point(149, 91)
        Me.x1.Name = "x1"
        Me.x1.Size = New System.Drawing.Size(100, 22)
        Me.x1.TabIndex = 17
        Me.x1.Text = "2.7"
        '
        'f1
        '
        Me.f1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f1.Location = New System.Drawing.Point(283, 91)
        Me.f1.Name = "f1"
        Me.f1.Size = New System.Drawing.Size(100, 22)
        Me.f1.TabIndex = 18
        Me.f1.Text = "17.8"
        '
        'x2
        '
        Me.x2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x2.Location = New System.Drawing.Point(149, 132)
        Me.x2.Name = "x2"
        Me.x2.Size = New System.Drawing.Size(100, 22)
        Me.x2.TabIndex = 19
        Me.x2.Text = "1.0"
        '
        'f2
        '
        Me.f2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f2.Location = New System.Drawing.Point(283, 132)
        Me.f2.Name = "f2"
        Me.f2.Size = New System.Drawing.Size(100, 22)
        Me.f2.TabIndex = 20
        Me.f2.Text = "14.2"
        '
        'x3
        '
        Me.x3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x3.Location = New System.Drawing.Point(149, 173)
        Me.x3.Name = "x3"
        Me.x3.Size = New System.Drawing.Size(100, 22)
        Me.x3.TabIndex = 21
        Me.x3.Text = "4.8"
        '
        'f3
        '
        Me.f3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f3.Location = New System.Drawing.Point(283, 173)
        Me.f3.Name = "f3"
        Me.f3.Size = New System.Drawing.Size(100, 22)
        Me.f3.TabIndex = 22
        Me.f3.Text = "38.3"
        '
        'x4
        '
        Me.x4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x4.Location = New System.Drawing.Point(149, 214)
        Me.x4.Name = "x4"
        Me.x4.Size = New System.Drawing.Size(100, 22)
        Me.x4.TabIndex = 23
        '
        'f4
        '
        Me.f4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f4.Location = New System.Drawing.Point(283, 214)
        Me.f4.Name = "f4"
        Me.f4.Size = New System.Drawing.Size(100, 22)
        Me.f4.TabIndex = 24
        '
        'x5
        '
        Me.x5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x5.Location = New System.Drawing.Point(149, 255)
        Me.x5.Name = "x5"
        Me.x5.Size = New System.Drawing.Size(100, 22)
        Me.x5.TabIndex = 25
        '
        'f5
        '
        Me.f5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f5.Location = New System.Drawing.Point(283, 255)
        Me.f5.Name = "f5"
        Me.f5.Size = New System.Drawing.Size(100, 22)
        Me.f5.TabIndex = 26
        '
        'x6
        '
        Me.x6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x6.Location = New System.Drawing.Point(149, 296)
        Me.x6.Name = "x6"
        Me.x6.Size = New System.Drawing.Size(100, 22)
        Me.x6.TabIndex = 27
        '
        'f6
        '
        Me.f6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f6.Location = New System.Drawing.Point(283, 296)
        Me.f6.Name = "f6"
        Me.f6.Size = New System.Drawing.Size(100, 22)
        Me.f6.TabIndex = 28
        '
        'x7
        '
        Me.x7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x7.Location = New System.Drawing.Point(149, 337)
        Me.x7.Name = "x7"
        Me.x7.Size = New System.Drawing.Size(100, 22)
        Me.x7.TabIndex = 29
        '
        'f7
        '
        Me.f7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f7.Location = New System.Drawing.Point(283, 337)
        Me.f7.Name = "f7"
        Me.f7.Size = New System.Drawing.Size(100, 22)
        Me.f7.TabIndex = 30
        '
        'x8
        '
        Me.x8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x8.Location = New System.Drawing.Point(149, 378)
        Me.x8.Name = "x8"
        Me.x8.Size = New System.Drawing.Size(100, 22)
        Me.x8.TabIndex = 31
        '
        'f8
        '
        Me.f8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f8.Location = New System.Drawing.Point(283, 378)
        Me.f8.Name = "f8"
        Me.f8.Size = New System.Drawing.Size(100, 22)
        Me.f8.TabIndex = 32
        '
        'x9
        '
        Me.x9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.x9.Location = New System.Drawing.Point(149, 423)
        Me.x9.Name = "x9"
        Me.x9.Size = New System.Drawing.Size(100, 22)
        Me.x9.TabIndex = 33
        '
        'f9
        '
        Me.f9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.f9.Location = New System.Drawing.Point(283, 423)
        Me.f9.Name = "f9"
        Me.f9.Size = New System.Drawing.Size(100, 22)
        Me.f9.TabIndex = 34
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 569)
        Me.Controls.Add(Me.fx)
        Me.Controls.Add(Me.x)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "PolynomialCurveFitting"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.CurveFittingLayoutPanel1.ResumeLayout(False)
        Me.CurveFittingLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents CurveFittingLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents x As TextBox
    Friend WithEvents fx As TextBox
    Friend WithEvents f9 As TextBox
    Friend WithEvents x9 As TextBox
    Friend WithEvents f8 As TextBox
    Friend WithEvents x8 As TextBox
    Friend WithEvents f7 As TextBox
    Friend WithEvents x7 As TextBox
    Friend WithEvents f6 As TextBox
    Friend WithEvents x6 As TextBox
    Friend WithEvents f5 As TextBox
    Friend WithEvents x5 As TextBox
    Friend WithEvents f4 As TextBox
    Friend WithEvents x4 As TextBox
    Friend WithEvents f3 As TextBox
    Friend WithEvents x3 As TextBox
    Friend WithEvents f2 As TextBox
    Friend WithEvents x2 As TextBox
    Friend WithEvents f1 As TextBox
    Friend WithEvents x1 As TextBox
    Friend WithEvents f0 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents x0 As TextBox
End Class
