Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class detailterima
    Private Sub detailterima_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
        Call tampildtl()
        Call aturDGV()
        Call IsiComboPenerima()
        Call IsiComboBarang()
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList

    End Sub

    Sub aturDGV()
        Try
            dg_barang.Columns(0).Width = 100
            dg_barang.Columns(1).Width = 130
            dg_barang.Columns(2).Width = 100
            dg_barang.Columns(3).Width = 100
            dg_barang.Columns(4).Width = 70
            dg_barang.Columns(0).HeaderText = "NOMOR TERIMA"
            dg_barang.Columns(1).HeaderText = "KODE BARANG"
            dg_barang.Columns(2).HeaderText = "STOK AWAL"
            dg_barang.Columns(3).HeaderText = "TOTAL TERIMA"
            dg_barang.Columns(4).HeaderText = "STOK AKHIR"
        Catch ex As Exception
            MessageBox.Show("Gagal mengatur DataGridView: " & ex.Message)
        End Try
    End Sub
    Sub tampildtl()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM detailterima", CONN)
        DS = New DataSet
        DA.Fill(DS, "detailterima")
        dg_barang.DataSource = DS.Tables("detailterima")
    End Sub
    Private Sub IsiComboPenerima()
        Try
            Call koneksi()
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("SELECT NoTrm FROM penerimaan", CONN)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
            While reader.Read()
                ComboBox2.Items.Add(reader("NoTrm").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data penerimaan: " & ex.Message)
        End Try
    End Sub
    Private Sub IsiComboBarang()
        Try
            Call koneksi()
            Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("SELECT kodebrg FROM barang", CONN)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(reader("kodebrg").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data barang: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_barang.CellMouseClick
        ComboBox1.Text = dg_barang.Rows(e.RowIndex).Cells(0).Value
        ComboBox2.Text = dg_barang.Rows(e.RowIndex).Cells(1).Value
        TextBox5.Text = dg_barang.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = dg_barang.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = dg_barang.Rows(e.RowIndex).Cells(4).Value
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into detailterima values ('" & ComboBox1.Text & "','" & ComboBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Insert Data detailterima Berhasil Dilakukan")
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            TextBox5.Text = ""
            TextBox4.Text = ""
            TextBox3.Text = ""
        Catch ex As Exception
            MessageBox.Show("Insert data detailterima gagal dilakukan.")
        End Try
        'Call tampildtr()
        Call aturDGV()

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedItem IsNot Nothing Then
            Try
                Call koneksi()
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("SELECT TotTrm FROM penerimaan WHERE NoTrm = @NoTrm", CONN)

                CMD.Parameters.AddWithValue("@NoTrm", ComboBox1.SelectedItem.ToString())
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                If reader.Read() Then
                    TextBox3.Text = reader("TotTrm").ToString()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data qtytrm: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Try
                Call koneksi()
                Dim CMD As New MySql.Data.MySqlClient.MySqlCommand("SELECT Jmlbrg FROM barang WHERE kodebrg = @Jmlbrg", CONN)
                CMD.Parameters.AddWithValue("@Jmlbrg", ComboBox1.SelectedItem.ToString())
                Dim reader As MySql.Data.MySqlClient.MySqlDataReader = CMD.ExecuteReader()
                If reader.Read() Then
                    TextBox5.Text = reader("Jmlbrg").ToString()
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Gagal mengambil data qtytrm: " & ex.Message)
            End Try
        End If
    End Sub
End Class