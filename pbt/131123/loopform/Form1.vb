Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For a As Integer = TextBox1.Text To TextBox2.Text Step +1
            If a Mod 2 = 1 Then
                ListBox1.Items.Add(a.ToString)
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim angka As Integer = TextBox2.Text
        While angka >= TextBox1.Text
            ListBox1.Items.Add(angka)
            angka -= 1
        End While
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim angka As Integer = TextBox1.Text
        Do While angka <= TextBox2.Text
            ListBox1.Items.Add(angka)
            angka += 1
        Loop
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ListBox1.Items.Clear()

    End Sub
End Class