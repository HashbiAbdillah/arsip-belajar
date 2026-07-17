Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class Penjualan

    Private connectionString As String = "server=localhost;database=kasir_rebuild;uid=root;pwd=;"
    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilpjl()
        Call aturDGV()
        Call isiComboBoxPemakai()
        Call isiComboBoxPelanggan()
        Dim input As String = TextBox3.Text
        Dim isValid As Boolean = False
        Dim total As Double
        If Double.TryParse(input, total) Then
            Dim decimalTotal As Decimal = Convert.ToDecimal(total)
        Else
        End If
    End Sub
    Sub tampilpjl()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from penjualan", CONN)
        DS = New DataSet
        DA.Fill(DS, "penjualan")
        Dim dt As DataTable = DS.Tables("penjualan")
        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row("tanggal")) Then
                Try
                    row("tanggal") = Convert.ToDateTime(row("tanggal"))
                Catch ex As Exception
                    row("tanggal") = DateTime.MinValue
                End Try
            Else
                row("tanggal") = DateTime.MinValue
            End If
        Next
        dg_pms.DataSource = dt

    End Sub
    Sub aturDGV()
        Try
            dg_pms.Columns(0).Width = 100
            dg_pms.Columns(1).Width = 130
            dg_pms.Columns(2).Width = 100
            dg_pms.Columns(3).Width = 150
            dg_pms.Columns(4).Width = 70
            dg_pms.Columns(5).Width = 100
            dg_pms.Columns(6).Width = 100
            dg_pms.Columns(7).Width = 100
            dg_pms.Columns(0).HeaderText = "FAKTUR"
            dg_pms.Columns(1).HeaderText = "TANGGAL "
            dg_pms.Columns(2).HeaderText = "ITEM"
            dg_pms.Columns(3).HeaderText = "TOTAL"
            dg_pms.Columns(4).HeaderText = "DIBAYAR"
            dg_pms.Columns(5).HeaderText = "KEMBALI"
            dg_pms.Columns(6).HeaderText = "KODE PEMAKAI"
            dg_pms.Columns(7).HeaderText = "KODE PELANGGAN"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_penjualan_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_pms.CellMouseClick

        TextBox1.Text = dg_pms.Rows(e.RowIndex).Cells(0).Value
        DateTimePicker1.Text = dg_pms.Rows(e.RowIndex).Cells(1).Value
        TextBox6.Text = dg_pms.Rows(e.RowIndex).Cells(2).Value
        TextBox7.Text = dg_pms.Rows(e.RowIndex).Cells(5).Value
        TextBox3.Text = dg_pms.Rows(e.RowIndex).Cells(3).Value
        TextBox2.Text = dg_pms.Rows(e.RowIndex).Cells(4).Value
        ComboBox1.Text = dg_pms.Rows(e.RowIndex).Cells(6).Value
        ComboBox2.Text = dg_pms.Rows(e.RowIndex).Cells(7).Value
    End Sub


    Sub isiComboBoxPemakai()
        Try
            Call koneksi()
            Dim cmd As New MySqlCommand("SELECT KodePmk FROM pemakai", CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(reader("KodePmk").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data pemakai: " & ex.Message)
        End Try
    End Sub

    Sub isiComboBoxPelanggan()
        Try
            Call koneksi()
            Dim cmd As New MySqlCommand("SELECT KodePelg FROM pelanggan", CONN)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox2.Items.Add(reader("KodePelg").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data pelanggan: " & ex.Message)
        End Try
    End Sub

    Sub hapuspjl()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from penjualan where Faktur = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox7.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Data User Gagal Dihapus.")
        End Try
    End Sub

    Sub updatenrm()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE penjualan SET  Tanggal='" & DateTimePicker1.Text & "',
            Item ='" & TextBox6.Text & "', Total= '" & TextBox3.Text & "',
            Dibayar= '" & TextBox2.Text & "', Kembali= '" & TextBox7.Text & "',
            KodePmk= '" & ComboBox1.Text & "', KodePelg= '" & ComboBox2.Text & "'
            WHERE Faktur = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Penjualan Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox7.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Update data penjualan gagal dilakukan" & ex.Message)
        End Try
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            TextBox7.Text = (Decimal.Parse(TextBox2.Text) - Decimal.Parse(TextBox3.Text)).ToString()
            str = "insert into penjualan values ('" & TextBox1.Text & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "','" & TextBox6.Text & "', '" & TextBox3.Text & "', '" & TextBox2.Text & "', '" & TextBox7.Text & "','" & ComboBox1.Text & "','" & ComboBox2.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data Penjualan Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox2.Text = ""
            TextBox7.Text = ""
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Insert data penjualan gagal dilakukan." & ex.Message)
        End Try
        Call tampilpjl()
        Call aturDGV()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call hapuspjl()
        Call tampilpjl()
        Call aturDGV()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call updatenrm()
        Call tampilpjl()
        Call aturDGV()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

 
End Class
