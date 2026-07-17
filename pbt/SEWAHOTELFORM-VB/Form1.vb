Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("silahkan masukan angka")
        Else
            TextBox4.Text = Val(TextBox2.Text) + Val(TextBox3.Text)
            TextBox4.Text = Val(TextBox4.Text) * Val(TextBox1.Text)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox5.Text = "" Then
            MsgBox("silahkan masukan angka")
        Else
            TextBox6.Text = Val(TextBox5.Text) - Val(TextBox4.Text)
        End If
    End Sub
End Class
