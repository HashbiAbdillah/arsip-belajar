Public Class Form1
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim gajipokok As Double
        Dim status As String
        Dim jmlanak As Integer
        Dim istri As Double
        Dim anak As Double
        Dim pph As Double
        Dim bersih As Double
        Dim total As Double
        Dim bonus As Double

        gajipokok = CDbl(TextBox2.Text)
        status = ComboBox1.SelectedItem.ToString()
        jmlanak = CInt(TextBox3.Text)

        istri = 0
        If status = "menikah" Then
            istri = 250000
        End If

        If jmlanak > 3 Then
            jmlanak = 3
        End If

        anak = 200000 * jmlanak
        pph = 0.05 * gajipokok
        total = gajipokok + istri + anak
        bonus = 0.05 * gajipokok
        bersih = total - pph

        TextBox4.Text = istri.ToString()
        TextBox5.Text = anak.ToString()
        TextBox6.Text = bonus.ToString()
        TextBox7.Text = total.ToString()
        TextBox8.Text = pph.ToString()
        TextBox9.Text = bersih.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "File Teks|*.txt"
        saveFileDialog.Title = "Data Pegawai"
        saveFileDialog.FileName = "Pegawai.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim nama As String = TextBox1.Text
            Dim pokok As Double = TextBox2.Text
            Dim status As String = ComboBox1.SelectedItem.ToString()
            Dim jumlah As Integer = CInt(TextBox3.Text)
            Dim istri As Double = CDbl(TextBox4.Text)
            Dim anak As Double = CDbl(TextBox5.Text)
            Dim pph As Double = CDbl(TextBox6.Text)
            Dim total As Double = CDbl(TextBox7.Text)
            Dim bersih As Double = CDbl(TextBox8.Text)
            Dim Bonus As Double = CDbl(TextBox9.Text)

            Dim fileText As String =
            $"Nama:{nama}{vbCrLf}
            Gaji pokok : {pokok}{vbCrLf}
            status : {status}{vbCrLf}
            Jumlah anak: {jumlah}{vbCrLf}
            Tunjangan Istri : {istri}{vbCrLf}
            Tunjangan anak : {anak}{vbCrLf}
            Bonus Gaji : {Bonus}{vbCrLf}
            Total Gaji : {total}{vbCrLf}
            PPH : {pph}{vbCrLf}
            Gaji Bersih : {bersih}{vbCrLf}"
            My.Computer.FileSystem.WriteAllText(saveFileDialog.FileName, fileText, False)
            MessageBox.Show("Data anda telah disimpan", "Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        Me.Close()
    End Sub
End Class
