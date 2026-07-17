Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        Dim hasil As Integer = a + b
        TextBox3.Text = hasil.ToString
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        Dim hasil As Integer = a - b
        TextBox3.Text = hasil.ToString
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        Dim hasil As Integer = a * b
        TextBox3.Text = hasil.ToString
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Integer = CInt(TextBox1.Text)
        Dim b As Integer = CInt(TextBox2.Text)
        If b = 0 Then
            MessageBox.Show("Tidak bisa membagi dengan 0")
            Exit Sub
        End If
        Dim hasil As Integer = a / b
        TextBox3.Text = hasil.ToString
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
