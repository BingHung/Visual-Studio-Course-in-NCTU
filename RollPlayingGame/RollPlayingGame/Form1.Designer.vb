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
        Me.Study = New System.Windows.Forms.Button()
        Me.Cheat = New System.Windows.Forms.Button()
        Me.Quit = New System.Windows.Forms.Button()
        Me.LabelScore = New System.Windows.Forms.Label()
        Me.TextBoxStudent = New System.Windows.Forms.TextBox()
        Me.TextBoxOpponent = New System.Windows.Forms.TextBox()
        Me.LabelKilled = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Study
        '
        Me.Study.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Study.Location = New System.Drawing.Point(23, 525)
        Me.Study.Name = "Study"
        Me.Study.Size = New System.Drawing.Size(123, 58)
        Me.Study.TabIndex = 0
        Me.Study.Text = "Fight"
        Me.Study.UseVisualStyleBackColor = True
        '
        'Cheat
        '
        Me.Cheat.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Cheat.Location = New System.Drawing.Point(164, 525)
        Me.Cheat.Name = "Cheat"
        Me.Cheat.Size = New System.Drawing.Size(126, 58)
        Me.Cheat.TabIndex = 1
        Me.Cheat.Text = "Magic"
        Me.Cheat.UseVisualStyleBackColor = True
        '
        'Quit
        '
        Me.Quit.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Quit.Location = New System.Drawing.Point(661, 525)
        Me.Quit.Name = "Quit"
        Me.Quit.Size = New System.Drawing.Size(126, 58)
        Me.Quit.TabIndex = 2
        Me.Quit.Text = "Quit"
        Me.Quit.UseVisualStyleBackColor = True
        '
        'LabelScore
        '
        Me.LabelScore.AutoSize = True
        Me.LabelScore.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelScore.Location = New System.Drawing.Point(34, 449)
        Me.LabelScore.Name = "LabelScore"
        Me.LabelScore.Size = New System.Drawing.Size(110, 27)
        Me.LabelScore.TabIndex = 3
        Me.LabelScore.Text = "Score = 0"
        '
        'TextBoxStudent
        '
        Me.TextBoxStudent.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxStudent.Location = New System.Drawing.Point(39, 142)
        Me.TextBoxStudent.Multiline = True
        Me.TextBoxStudent.Name = "TextBoxStudent"
        Me.TextBoxStudent.Size = New System.Drawing.Size(352, 282)
        Me.TextBoxStudent.TabIndex = 5
        '
        'TextBoxOpponent
        '
        Me.TextBoxOpponent.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TextBoxOpponent.Location = New System.Drawing.Point(426, 142)
        Me.TextBoxOpponent.Multiline = True
        Me.TextBoxOpponent.Name = "TextBoxOpponent"
        Me.TextBoxOpponent.Size = New System.Drawing.Size(384, 282)
        Me.TextBoxOpponent.TabIndex = 6
        '
        'LabelKilled
        '
        Me.LabelKilled.AutoSize = True
        Me.LabelKilled.Font = New System.Drawing.Font("新細明體", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.LabelKilled.Location = New System.Drawing.Point(421, 449)
        Me.LabelKilled.Name = "LabelKilled"
        Me.LabelKilled.Size = New System.Drawing.Size(89, 27)
        Me.LabelKilled.TabIndex = 4
        Me.LabelKilled.Text = "Killed :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("新細明體", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Label1.Location = New System.Drawing.Point(60, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(718, 64)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "This Semester Pass or Fail ?"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 605)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxOpponent)
        Me.Controls.Add(Me.TextBoxStudent)
        Me.Controls.Add(Me.LabelKilled)
        Me.Controls.Add(Me.LabelScore)
        Me.Controls.Add(Me.Quit)
        Me.Controls.Add(Me.Cheat)
        Me.Controls.Add(Me.Study)
        Me.Name = "Form1"
        Me.Text = "Student _RPG Simulation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Study As Button
    Friend WithEvents Cheat As Button
    Friend WithEvents Quit As Button
    Friend WithEvents LabelScore As Label
    Friend WithEvents TextBoxStudent As TextBox
    Friend WithEvents TextBoxOpponent As TextBox
    Friend WithEvents LabelKilled As Label
    Friend WithEvents Label1 As Label
End Class
