Imports MySql.Data.MySqlClient
Public Class barang
    Private Sub Fbarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Sub Tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "barang")
        dg_barang.DataSource = DS.Tables("barang")
    End Sub
    Sub Hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from barang where kodebrg = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Sub AturDGV()
        Try
            dg_barang.Columns(0).Width = 100
            dg_barang.Columns(1).Width = 130
            dg_barang.Columns(2).Width = 100
            dg_barang.Columns(3).Width = 150
            dg_barang.Columns(4).Width = 70
            dg_barang.Columns(5).Width = 100
            dg_barang.Columns(0).HeaderText = "KODE BARANG"
            dg_barang.Columns(1).HeaderText = "NAMA BARANG"
            dg_barang.Columns(2).HeaderText = "SATUAN"
            dg_barang.Columns(3).HeaderText = "JUMLAH BARANG"
            dg_barang.Columns(4).HeaderText = "STOK"
            dg_barang.Columns(5).HeaderText = "HARGA"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into barang values ('" & TextBox1.Text & "','" & TextBox2.Text & "', 
            '" & ComboBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', 
            '" & TextBox5.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data Barang Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Insert data barang gagal dilakukan.")
        End Try
        Call Tampilbrg()
        Call AturDGV()

    End Sub

    Private Sub Kapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Hapusbrg()
        Call Tampilbrg()
        Call AturDGV()

    End Sub

    Private Sub Dg_barang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_barang.CellMouseClick
        TextBox1.Text = dg_barang.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dg_barang.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dg_barang.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = dg_barang.Rows(e.RowIndex).Cells(4).Value
        TextBox5.Text = dg_barang.Rows(e.RowIndex).Cells(5).Value
        ComboBox1.Text = dg_barang.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
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
            str = "UPDATE barang SET Namabarang = '" & TextBox2.Text & "', 
            Satuan = '" & ComboBox1.Text & "', Jmlbrg = '" & TextBox3.Text & "', 
            stokmin = '" & TextBox4.Text & "',
            Harga = '" & TextBox5.Text & "' WHERE kodebrg = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Barang Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Update Data Barang gagal Dilakukan.")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
