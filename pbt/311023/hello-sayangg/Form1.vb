Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nama
        nama = TextBox1.Text
        Dim nama2
        nama2 = TextBox2.Text
        MessageBox.Show("Halooo " + nama + " pacarnya " + nama2 + "terimakasih udah absen", "Absen", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
