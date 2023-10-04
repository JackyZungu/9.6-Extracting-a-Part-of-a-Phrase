Public Class Form1
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        Dim myPhase As String
        Dim pos, n As Integer
        myPhase = TextBox1.Text
        pos = TextBox2.Text
        n = TextBox3.Text

        TextBox4.Text = Mid(myPhase, pos, n)

        TextBox4.Enabled = False

    End Sub
End Class
