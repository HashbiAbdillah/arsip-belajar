Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Sub tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from barang", CONN)
        DS = New DataSet
        DA.Fill(DS, "barang")
        dg_barang.DataSource = DS.Tables("barang")
    End Sub
    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from barang where Kodebarang = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub aturDGV()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into barang values ('" & TextBox1.Text & "','" & TextBox2.Text & "', 
            '" & ComboBox1.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', 
            '" & TextBox6.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data Barang Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Insert data barang GAGAL dilakukan.")
        End Try
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call hapusbrg()
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Private Sub dg_barang_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_barang.CellMouseClick
        TextBox1.Text = dg_barang.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dg_barang.Rows(e.RowIndex).Cells(1).Value
        TextBox4.Text = dg_barang.Rows(e.RowIndex).Cells(3).Value
        TextBox5.Text = dg_barang.Rows(e.RowIndex).Cells(4).Value
        TextBox6.Text = dg_barang.Rows(e.RowIndex).Cells(5).Value
        ComboBox1.Text = dg_barang.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call updatebrg()
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Sub updatebrg()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE barang SET Namabarang = '" & TextBox2.Text & "', 
            Satuan = '" & ComboBox1.Text & "', Jumlahbarang = '" & TextBox4.Text & "', 
            Statusminimal = '" & TextBox4.Text & "',
            Harga = '" & TextBox5.Text & "' WHERE Kodebarang = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Barang Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Update Data Barang gagal Dilakukan.")
        End Try
    End Sub


End Class
