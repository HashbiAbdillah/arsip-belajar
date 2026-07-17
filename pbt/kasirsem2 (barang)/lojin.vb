Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class lojin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Harap isi Username dan Password terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            MessageBox.Show("Harap lengkapi data terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Call koneksi()
                CMD = New MySqlCommand("SELECT * FROM pemakai WHERE NamaPmk = @usn AND PassPmk = @pw", CONN)
                CMD.Parameters.AddWithValue("@usn", TextBox1.Text)
                CMD.Parameters.AddWithValue("@pw", TextBox2.Text)
                RD = CMD.ExecuteReader
                RD.Read()

                If RD.HasRows Then

                    If RD("StatusPmk").ToString = "ADMIN" Then
                        'Login sebagai Admin
                        Form3.Show()
                        TextBox1.Clear()
                        TextBox2.Clear()
                        Me.Hide()
                    ElseIf RD("StatusPmk").ToString = "KASIR" Then
                        'login sebagai kasir
                        Form3.Show()
                        Form3.PEMASOKToolStripMenuItem.Visible = False
                        Form3.DETAILJUALToolStripMenuItem.Visible = False
                        Form3.PEMAKAIToolStripMenuItem.Visible = False
                        TextBox1.Clear()
                        TextBox2.Clear()
                        Me.Hide()
                    ElseIf RD("StatusPmk").ToString = "PETUGAS" Then
                        'login sebagai petugas
                        Form3.Show()
                        Form3.PEMAKAIToolStripMenuItem.Visible = False
                        Form3.PENJUALANToolStripMenuItem1.Visible = False
                        Form3.PELANGGANToolStripMenuItem.Visible = False
                        Form3.PELANGGANToolStripMenuItem.Visible = False
                        TextBox1.Clear()
                        TextBox2.Clear()
                        Me.Hide()
                    Else
                        MessageBox.Show("Role tidak tersedia", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Periksa kembali Username dan Password", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    TextBox1.Focus()
                    TextBox2.Clear()
                End If

                RD.Close()
            Catch ex As Exception
                MessageBox.Show("Periksa", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TextBox1.Focus()
                TextBox2.Clear()
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class