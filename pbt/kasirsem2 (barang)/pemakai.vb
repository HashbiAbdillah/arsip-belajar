Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class pemakai

    Sub tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from pemakai", CONN)
        DS = New DataSet
        DA.Fill(DS, "pemakai")
        dg_pms.DataSource = DS.Tables("pemakai")
    End Sub

    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from pemakai where KodePmk = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub aturDGV()
        Try
            dg_pms.Columns(0).Width = 100
            dg_pms.Columns(1).Width = 130
            dg_pms.Columns(2).Width = 100
            dg_pms.Columns(3).Width = 150
            dg_pms.Columns(0).HeaderText = "KODE PEMAKAI"
            dg_pms.Columns(1).HeaderText = "NAMA PEMAKAI"
            dg_pms.Columns(2).HeaderText = "PASS PEMAKAI"
            dg_pms.Columns(3).HeaderText = "STATUS"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_pms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_pms.CellMouseClick
        TextBox1.Text = dg_pms.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dg_pms.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = dg_pms.Rows(e.RowIndex).Cells(3).Value
        TextBox6.Text = dg_pms.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into pemakai values ('" & TextBox1.Text & "','" & TextBox2.Text & "', 
            '" & TextBox6.Text & "', '" & ComboBox1.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data Pemakai Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.Text = ""
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show("Insert data Pemakai gagal dilakukan.")
        End Try
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call hapusbrg()
        Call tampilbrg()
        Call aturDGV()
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
            str = "UPDATE pemakai SET NamaPmk = '" & TextBox2.Text & "', 
            PassPmk = '" & TextBox6.Text & "', StatusPmk = '" & ComboBox1.Text & "' WHERE KodePmk = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Pemakai Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            ComboBox1.SelectedIndex = -1
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub pemakai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilbrg()
        Call aturDGV()
    End Sub
End Class