Public Class Form4

    Dim score As Integer = 0
    Dim user As Integer = 0

    Dim strComputer() As String = {"Rock", "Paper", "Scissor"}


    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Label3.Text = score
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        user = 1
        Dim rando As Integer = GetRandom(1, 3)
        Label2.Text = strComputer(rando)
        If rando = 1 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        ElseIf rando = 2 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        Else
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label3.Text = score
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        user = 2
        Dim rando As Integer = GetRandom(1, 3)
        Label2.Text = strComputer(rando)
        If rando = 1 Then
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label3.Text = score
        ElseIf rando = 2 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        Else
            MessageBox.Show("You Lose!")
            Label2.Text = ""

        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user = 3
        Dim rando As Integer = GetRandom(1, 3)
        Label2.Text = strComputer(rando)
        If rando = 1 Then
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        ElseIf rando = 2 Then
            MessageBox.Show("You Won!")
            score += 1
            Label2.Text = ""
            Label3.Text = score
        Else
            MessageBox.Show("You Lose!")
            Label2.Text = ""
        End If
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class