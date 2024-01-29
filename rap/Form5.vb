Public Class Form5

    Dim playerPosition As Integer = 1
    Dim isDone As Boolean = False

    Private Sub startBtn_Click(sender As Object, e As EventArgs) Handles startBtn.Click
        tile1.Enabled = True
        tile2.Enabled = True
        startBtn.Enabled = False
        Label1.Text = ""
    End Sub
    Private Sub tile1_Click(sender As Object, e As EventArgs) Handles tile1.Click
        tile3.Enabled = True
        tile4.Enabled = True
        tile2.Enabled = False
        tile1.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile2_Click(sender As Object, e As EventArgs) Handles tile2.Click
        tile3.Enabled = True
        tile4.Enabled = True
        tile1.Enabled = False
        tile2.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile3_Click(sender As Object, e As EventArgs) Handles tile3.Click
        tile5.Enabled = True
        tile6.Enabled = True
        tile4.Enabled = False
        tile1.Enabled = False
        tile2.Enabled = False
        tile3.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile4_Click(sender As Object, e As EventArgs) Handles tile4.Click
        tile5.Enabled = True
        tile6.Enabled = True
        tile3.Enabled = False
        tile1.Enabled = False
        tile2.Enabled = False
        tile4.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile5_Click(sender As Object, e As EventArgs) Handles tile5.Click
        tile7.Enabled = True
        tile8.Enabled = True
        tile6.Enabled = False
        tile3.Enabled = False
        tile4.Enabled = False
        tile5.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile6_Click(sender As Object, e As EventArgs) Handles tile6.Click
        tile7.Enabled = True
        tile8.Enabled = True
        tile6.Enabled = False
        tile3.Enabled = False
        tile4.Enabled = False
        tile5.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile7_Click(sender As Object, e As EventArgs) Handles tile7.Click
        tile9.Enabled = True
        tile10.Enabled = True
        tile8.Enabled = False
        tile5.Enabled = False
        tile6.Enabled = False
        tile7.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile8_Click(sender As Object, e As EventArgs) Handles tile8.Click
        tile9.Enabled = True
        tile10.Enabled = True
        tile8.Enabled = False
        tile5.Enabled = False
        tile6.Enabled = False
        tile7.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile9_Click(sender As Object, e As EventArgs) Handles tile9.Click
        tile11.Enabled = True
        tile12.Enabled = True
        tile10.Enabled = False
        tile7.Enabled = False
        tile8.Enabled = False
        tile9.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile10_Click(sender As Object, e As EventArgs) Handles tile10.Click
        tile11.Enabled = True
        tile12.Enabled = True
        tile10.Enabled = False
        tile7.Enabled = False
        tile8.Enabled = False
        tile9.Enabled = False
        randomFoot()
    End Sub

    Private Sub tile11_Click(sender As Object, e As EventArgs) Handles tile11.Click
        finishBtn.Enabled = True
        tile12.Enabled = False
        tile9.Enabled = False
        tile10.Enabled = False
        tile11.Enabled = False
        lastGlas()
    End Sub

    Private Sub tile12_Click(sender As Object, e As EventArgs) Handles tile12.Click
        finishBtn.Enabled = True
        tile12.Enabled = False
        tile9.Enabled = False
        tile10.Enabled = False
        tile11.Enabled = False
        lastGlas()

    End Sub

    Private Sub finishBtn_Click(sender As Object, e As EventArgs) Handles finishBtn.Click
        Label1.Text = "You Won!"
        resetGame()
    End Sub



    Private Sub gameOver()
        isDone = True
        If isDone Then
            Label1.Text = "You Lose!"
            resetGame()
        End If
    End Sub

    Private Sub randomFoot()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            Label1.Text = "👍"
        End If

    End Sub
    Private Sub lastGlas()
        Dim rando As Integer = GetRandom(1, 3)
        If rando = 1 Then
            gameOver()
        Else
            finishBtn.Enabled = True
        End If

    End Sub

    Private Sub resetGame()
        startBtn.Enabled = True
        tile1.Enabled = False
        tile2.Enabled = False
        tile3.Enabled = False
        tile4.Enabled = False
        tile5.Enabled = False
        tile6.Enabled = False
        tile7.Enabled = False
        tile8.Enabled = False
        tile9.Enabled = False
        tile10.Enabled = False
        tile11.Enabled = False
        tile12.Enabled = False
        finishBtn.Enabled = False
    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class