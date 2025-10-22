Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub UpdateFontStyle()
        Dim style As FontStyle = FontStyle.Regular

        If CheckBox1.Checked Then
            style = style Or FontStyle.Italic
        End If

        If CheckBox2.Checked Then
            style = style Or FontStyle.Bold
        End If

        Label1.Font = New Font(Label1.Font, style)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Label1.ForeColor = Color.Red
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Label1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = TextBox1.Text
    End Sub
End Class