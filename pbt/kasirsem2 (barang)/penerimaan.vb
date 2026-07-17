Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class penerimaan
    Private Sub Tampilbrg()
        Call koneksi()
        Dim DA As New MySql.Data.MySqlClient.MySqlDataAdapter("select * from penerimaan", CONN)
        Dim DS As New DataSet
        DA.Fill(DS, "penerimaan")

        Dim dt As DataTable = DS.Tables("penerimaan")
        For Each row As DataRow In dt.Rows
            If Not IsDBNull(row("TanggalTrm")) Then
                Try
                    row("TanggalTrm") = Convert.ToDateTime(row("TanggalTrm"))
                Catch ex As Exception
                    row("TanggalTrm") = DateTime.MinValue
                End Try
            Else
                row("TanggalTrm") = DateTime.MinValue
            End If
        Next

        dg_pms.DataSource = dt
    End Sub

    Private Sub penerimaan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Sub Hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from penerimaan where NoTrm = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
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
            dg_pms.Columns(0).HeaderText = "NO TERIMA"
            dg_pms.Columns(1).HeaderText = "TANGGAL TERIMA"
            dg_pms.Columns(2).HeaderText = "KODE PEMASOK"
            dg_pms.Columns(3).HeaderText = "NO BON"
            dg_pms.Columns(4).HeaderText = "TOTAL TERIMA"
            dg_pms.Columns(5).HeaderText = "KODE PEMAKAI"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into penerimaan values ('" & TextBox1.Text & "','" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', 
            '" & TextBox6.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', 
            '" & TextBox5.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data penrerimaan Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Hapusbrg()
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Private Sub dg_pms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_pms.CellMouseClick
        TextBox1.Text = dg_pms.Rows(e.RowIndex).Cells(0).Value
        DateTimePicker1.Text = dg_pms.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dg_pms.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = dg_pms.Rows(e.RowIndex).Cells(4).Value
        TextBox5.Text = dg_pms.Rows(e.RowIndex).Cells(5).Value
        TextBox6.Text = dg_pms.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Sub Updatebrg()
        Try
            Call koneksi()
            Dim str As String
            str = "UPDATE penerimaan SET NomorBon = '" & TextBox3.Text & "', 
            TanggalTrm = '" & DateTimePicker1.Value.ToString("yyyy-MM-dd") & "', KodePms = '" & TextBox6.Text & "', 
            TotTrm = '" & TextBox4.Text & "',
            KodePmk = '" & TextBox5.Text & "' WHERE NoTrm = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Barang Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox6.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Updatebrg()
        Call Tampilbrg()
        Call AturDGV()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class