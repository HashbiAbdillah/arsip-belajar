Imports MySql.Data.MySqlClient
Public Class pelanggan
    Sub Tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from pelanggan", CONN)
        DS = New DataSet
        DA.Fill(DS, "pelanggan")
        dg_pms.DataSource = DS.Tables("pelanggan")
    End Sub

    Sub Hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from pelanggan where KodePelg = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub AturDGV()
        Try
            dg_pms.Columns(0).Width = 100
            dg_pms.Columns(1).Width = 130
            dg_pms.Columns(2).Width = 100
            dg_pms.Columns(3).Width = 150
            dg_pms.Columns(4).Width = 70
            dg_pms.Columns(5).Width = 100
            dg_pms.Columns(0).HeaderText = "KODE PELANGGAN"
            dg_pms.Columns(1).HeaderText = "NAMA PELANGGAN"
            dg_pms.Columns(2).HeaderText = "ALAMAT"
            dg_pms.Columns(3).HeaderText = "NO TELP"
            dg_pms.Columns(5).HeaderText = "JENIS KELAMIN"
            dg_pms.Columns(4).HeaderText = "EMAIL PELANGGAN"
        Catch ex As Exception
        End Try
    End Sub



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilbrg()
        Call AturDGV()
    End Sub



    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into pelanggan values ('" & TextBox1.Text & "','" & TextBox2.Text & "', 
            '" & TextBox6.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', 
            '" & ComboBox1.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data pelanggan Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            ComboBox1.SelectedIndex = -1
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Private Sub Dg_pms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_pms.CellMouseClick
        TextBox1.Text = dg_pms.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dg_pms.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dg_pms.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = dg_pms.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = dg_pms.Rows(e.RowIndex).Cells(2).Value
        ComboBox1.Text = dg_pms.Rows(e.RowIndex).Cells(5).Value
    End Sub

    Private Sub Hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Hapusbrg()
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Updatebrg()
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Sub Updatebrg()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE pelanggan SET NamaPlg = '" & TextBox2.Text & "', 
            JK = '" & ComboBox1.Text & "', TeleponPlg = '" & TextBox3.Text & "', 
            EmailPlg = '" & TextBox4.Text & "',
            AlamatPlg = '" & TextBox6.Text & "' WHERE KodePelg = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Barang Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox6.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class