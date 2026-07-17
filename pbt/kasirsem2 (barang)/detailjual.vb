Imports MySql.Data.MySqlClient

Public Class detailjual


    Sub tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from detailjual", CONN)
        DS = New DataSet
        DA.Fill(DS, "detailjual")
        DG.DataSource = DS.Tables("detailjual")
    End Sub

    Private Sub detailjual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilbrg()
        Call aturDGV()
        Call isiComboBoxBarang()

    End Sub
    Sub aturDGV()
        Try
            DG.Columns(1).Width = 100
            DG.Columns(2).Width = 130
            DG.Columns(3).Width = 100
            DG.Columns(4).Width = 150
            DG.Columns(5).Width = 70
            DG.Columns(6).Width = 100
            DG.Columns(1).HeaderText = "FAKTUR"
            DG.Columns(2).HeaderText = "KODE_BARANG"
            DG.Columns(3).HeaderText = "NAMA_BARANG"
            DG.Columns(4).HeaderText = "HARGA JUAL"
            DG.Columns(5).HeaderText = "JUMLAH"
            DG.Columns(6).HeaderText = "SUBTOTAL"


        Catch ex As Exception
        End Try
    End Sub
    Sub isiComboBoxBarang()
        Try
            Call koneksi()
            Dim cmd As New MySql.Data.MySqlClient.MySqlCommand("SELECT kodebrg FROM barang", CONN)
            Dim reader As MySql.Data.MySqlClient.MySqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                ComboBox1.Items.Add(reader("kodebrg").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data barang: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        If ComboBox1.SelectedIndex = -1 Then
            MessageBox.Show("Silakan pilih Kode Barang yang valid!")
            Return
        End If

        Dim hargaJual As Decimal
        Dim jumlah As Integer

        If Not Decimal.TryParse(TextBox3.Text, hargaJual) Then
            MessageBox.Show("Harga jual tidak valid!")
            Return
        End If

        If Not Integer.TryParse(TextBox4.Text, jumlah) Then
            MessageBox.Show("Jumlah tidak valid!")
            Return
        End If

        Dim subtotal As Decimal = hargaJual * jumlah
        TextBox5.Text = subtotal.ToString()

        Call koneksi()
        Try
            Dim str As String
            str = "INSERT INTO detailjual (Faktur, KodeBrg, NamaBrg, HargaJual, Jumlah, Subtotal) VALUES (@Faktur, @KodeBrg, @NamaBrg, @HargaJual, @Jumlah, @Subtotal)"
            Using CMD As New MySqlCommand(str, CONN)
                CMD.Parameters.AddWithValue("@Faktur", TextBox1.Text)
                CMD.Parameters.AddWithValue("@KodeBrg", ComboBox1.SelectedItem.ToString())
                CMD.Parameters.AddWithValue("@NamaBrg", TextBox2.Text)
                CMD.Parameters.AddWithValue("@HargaJual", hargaJual)
                CMD.Parameters.AddWithValue("@Jumlah", jumlah)
                CMD.Parameters.AddWithValue("@Subtotal", subtotal)
                CMD.ExecuteNonQuery()
            End Using
            MessageBox.Show("Insert Data DetailJual Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            ComboBox1.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Insert data DetailJual gagal dilakukan: " & ex.Message)
        End Try
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from detailjual where Faktur= '" & TextBox1.Text & "'"
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
            MessageBox.Show("Data User Gagal Dihapus.")
        End Try

    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call hapusbrg()
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Sub updatebrg()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE detailjual SET KodeBrg ='" & ComboBox1.SelectedItem.ToString() & "',
            NamaBrg ='" & TextBox2.Text & "', HargaJual ='" & TextBox3.Text & "',
            Jumlah = '" & TextBox4.Text & "', Subtotal = '" & TextBox5.Text & "' WHERE Faktur = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Detail Jual Berhasil Dilakukan.")
            TextBox1.Text = ""
            ComboBox1.SelectedIndex = -1
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        Catch ex As Exception
            MessageBox.Show("Update data Detail Jual gagal dilakukan: " & ex.Message)
        End Try
    End Sub

    Private Sub DG_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG.CellMouseClick
        TextBox1.Text = DG.Rows(e.RowIndex).Cells(0).Value
        ComboBox1.Text = DG.Rows(e.RowIndex).Cells(1).Value
        TextBox2.Text = DG.Rows(e.RowIndex).Cells(2).Value
        TextBox3.Text = DG.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = DG.Rows(e.RowIndex).Cells(4).Value
        TextBox5.Text = DG.Rows(e.RowIndex).Cells(5).Value

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex <> -1 Then
            Dim kodeBrg As String = ComboBox1.SelectedItem.ToString()
            Dim barangDetails As BarangDetails = GetBarangDetails(kodeBrg)
            If barangDetails IsNot Nothing Then
                TextBox2.Text = barangDetails.NamaBrg

                TextBox4.Text = barangDetails.JumlahBrg.ToString()
                TextBox3.Text = barangDetails.Harga.ToString()
            End If
        End If

    End Sub

    Private Function GetBarangDetails(kodeBrg As String) As BarangDetails
        Dim query As String = "SELECT NamaBarang, Satuan, Jmlbrg, stokmin, Harga FROM barang WHERE kodebrg = @kodebrg"

        Using cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@KodeBrg", kodeBrg)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Return New BarangDetails() With {
                    .NamaBrg = If(reader.IsDBNull(reader.GetOrdinal("NamaBarang")), String.Empty, reader("NamaBarang").ToString()),
                    .Satuan = If(reader.IsDBNull(reader.GetOrdinal("Satuan")), String.Empty, reader("Satuan").ToString()),
                    .JumlahBrg = If(reader.IsDBNull(reader.GetOrdinal("Jmlbrg")), 0, Convert.ToInt32(reader("Jmlbrg"))),
                    .StatusMinimal = If(reader.IsDBNull(reader.GetOrdinal("stokmin")), String.Empty, reader("stokmin").ToString()),
                    .Harga = If(reader.IsDBNull(reader.GetOrdinal("Harga")), 0D, Convert.ToDecimal(reader("Harga")))
                }
                End If
            End Using
            CONN.Close()
        End Using
        Return Nothing
    End Function

    Public Class BarangDetails
        Public Property NamaBrg As String
        Public Property Satuan As String
        Public Property JumlahBrg As Integer
        Public Property StatusMinimal As String
        Public Property Harga As Decimal
    End Class

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call updatebrg()
        Call tampilbrg()
        Call aturDGV()

    End Sub
End Class