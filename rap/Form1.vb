Public Class Form1
    Dim user As String = "a"
    Dim pass As String = "a"

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim userInp As String = TextBox1.Text
        Dim passInp As String = TextBox2.Text

        If user = userInp And pass = passInp Then
            Form2.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid Credentials.")
            TextBox1.Text = ""
            TextBox2.Text = ""
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
