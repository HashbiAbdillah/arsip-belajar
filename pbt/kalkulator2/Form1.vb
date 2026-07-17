Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) / Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Clear()
            TextBox1.Clear()
            TextBox2.Clear()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) - Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) Mod Val(TextBox2.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("silakan masukan angka")
        Else
            TextBox3.Text = Val(TextBox1.Text) \ Val(TextBox2.Text)
        End If
    End Sub
End Class
