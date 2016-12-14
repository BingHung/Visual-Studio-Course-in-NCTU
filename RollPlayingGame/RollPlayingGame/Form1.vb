Public Class Form1

    Dim Student As ClassCourse.Student
    Dim HeatTransfer As ClassCourse.Course
    Dim Convection As ClassCourse.Course
    Dim TwoPhaseFlow As ClassCourse.Course
    Dim Thermodynamic As ClassCourse.Course
    Dim FluidDynamic As ClassCourse.Course
    Dim HeatExchangerDesign As ClassCourse.Course
    Public Score As Integer
    Const MagicPower As Integer = 10
    Dim Opponent As ClassCourse.Course

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadSettings()

    End Sub

    Private Sub GetEnemy()

        Dim EnemyNumber As Integer

        Randomize()

        EnemyNumber = (Rnd() * 6) + 1

        If EnemyNumber = 1 Then
            Opponent = HeatTransfer
        ElseIf EnemyNumber = 2 Then
            Opponent = Thermodynamic
        ElseIf EnemyNumber = 3 Then
            Opponent = FluidDynamic
        ElseIf EnemyNumber = 4 Then
            Opponent = TwoPhaseFlow
        ElseIf EnemyNumber = 5 Then
            Opponent = HeatExchangerDesign
        Else
            Opponent = Convection
        End If

        WriteStates()

    End Sub

    Private Sub WriteStates()
        TextBoxStudent.Clear()
        TextBoxStudent.Text = "Name = " + Student.Name + vbNewLine
        TextBoxStudent.Text += "Armor = " + Str(Student.Attendence) + vbNewLine
        TextBoxStudent.Text += "Health = " + Str(Student.Energy) + vbNewLine
        TextBoxStudent.Text += "Magic = " + Str(Student.WorkingHard) + vbNewLine
        TextBoxStudent.Text += "Power = " + Str(Student.DoHW) + vbNewLine

        TextBoxOpponent.Clear()
        TextBoxOpponent.Text = "Opponent = " + Opponent.Name + vbNewLine
        TextBoxOpponent.Text += "Armor = " + Str(Opponent.Attendence) + vbNewLine
        TextBoxOpponent.Text += "Health = " + Str(Opponent.Loading) + vbNewLine
        TextBoxOpponent.Text += "Magic = " + Str(Opponent.MidtermFinal) + vbNewLine
        TextBoxOpponent.Text += "Power = " + Str(Opponent.HW) + vbNewLine
    End Sub

    Public Sub LoadSettings()

        Score = 0

        LabelScore.Text = "Score = "
        LabelKilled.Text = ""

        Student.Name = "StudentA"
        Student.Attendence = 0
        Student.Energy = 20
        Student.WorkingHard = 2
        Student.DoHW = 3

        HeatTransfer.Name = "Heat Transfer"
        HeatTransfer.Attendence = 0
        HeatTransfer.Loading = 1
        HeatTransfer.MidtermFinal = 0
        HeatTransfer.HW = 1

        Thermodynamic.Name = "Thermodynamic"
        Thermodynamic.Attendence = 0
        Thermodynamic.Loading = 1
        Thermodynamic.MidtermFinal = 0
        Thermodynamic.HW = 2

        FluidDynamic.Name = "FluidDynamic"
        FluidDynamic.Attendence = 0
        FluidDynamic.Loading = 4
        FluidDynamic.MidtermFinal = 0
        FluidDynamic.HW = 4

        Convection.Name = "Convection"
        Convection.Attendence = 0
        Convection.Loading = 2
        Convection.MidtermFinal = 0
        Convection.HW = 3

        TwoPhaseFlow.Name = "TwoPhaseFlow"
        TwoPhaseFlow.Attendence = 0
        TwoPhaseFlow.Loading = 7
        TwoPhaseFlow.MidtermFinal = 0
        TwoPhaseFlow.HW = 2

        HeatExchangerDesign.Name = "HeatExchangerDesign"
        HeatExchangerDesign.Attendence = 0
        HeatExchangerDesign.Loading = 5
        HeatExchangerDesign.MidtermFinal = 0
        HeatExchangerDesign.HW = 7

        GetEnemy()
    End Sub

    Private Sub Study_Click(sender As Object, e As EventArgs) Handles Study.Click
        Randomize()
        Student.Energy = Student.Energy - (Rnd() * Opponent.HW)
        Randomize()
        Opponent.Loading = Opponent.Loading - (Rnd() * Student.DoHW)
        CheckDeath()
    End Sub

    Private Sub CheckDeath()

        WriteStates()

        If Opponent.Loading <= 0 Then
            LabelKilled.Text = "Killed : " + Opponent.Name
            Score += Opponent.HW
            LabelScore.Text = "Score :" + Str(Score)
            GetEnemy()
        Else
            LabelKilled.Text = "Enemy Not Killed"
        End If

        If Student.Energy <= 0 Then
            PlayAgain.ShowDialog()
        End If

    End Sub

    Private Sub Cheat_Click(sender As Object, e As EventArgs) Handles Cheat.Click
        If Student.WorkingHard > 0 Then
            Opponent.Loading = Opponent.Loading - MagicPower
            Student.WorkingHard = Student.WorkingHard - 1
        End If

        If Opponent.Loading > 0 Then
            Student.Energy = Student.Energy - (Rnd() * Opponent.HW)
        End If
        CheckDeath()
    End Sub

    Private Sub Quit_Click(sender As Object, e As EventArgs) Handles Quit.Click
        Application.Exit()
    End Sub
End Class
