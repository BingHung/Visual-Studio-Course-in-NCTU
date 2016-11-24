<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pokeball = New System.Windows.Forms.PictureBox()
        Me.SpeedDisplay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.pokeball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'pokeball
        '
        Me.pokeball.ErrorImage = CType(resources.GetObject("pokeball.ErrorImage"), System.Drawing.Image)
        Me.pokeball.Image = Global.Bouncing_Ball.My.Resources.Resources.Pokeball
        Me.pokeball.InitialImage = CType(resources.GetObject("pokeball.InitialImage"), System.Drawing.Image)
        Me.pokeball.Location = New System.Drawing.Point(388, 314)
        Me.pokeball.Name = "pokeball"
        Me.pokeball.Size = New System.Drawing.Size(100, 100)
        Me.pokeball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pokeball.TabIndex = 0
        Me.pokeball.TabStop = False
        '
        'SpeedDisplay
        '
        Me.SpeedDisplay.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.SpeedDisplay.Location = New System.Drawing.Point(192, 14)
        Me.SpeedDisplay.Name = "SpeedDisplay"
        Me.SpeedDisplay.ReadOnly = True
        Me.SpeedDisplay.Size = New System.Drawing.Size(68, 33)
        Me.SpeedDisplay.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Speed :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(979, 704)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SpeedDisplay)
        Me.Controls.Add(Me.pokeball)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pokeball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents pokeball As PictureBox
    Friend WithEvents SpeedDisplay As TextBox
    Friend WithEvents Label1 As Label
End Class
