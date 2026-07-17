Imports MySql.Data.MySqlClient

Public Class pemasok
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilbrg()
        Call aturDGV()
    End Sub

    Sub tampilbrg()
        Call koneksi()
        DA = New MySql.Data.MySqlClient.MySqlDataAdapter("select * from pemasok", CONN)
        DS = New DataSet
        DA.Fill(DS, "pemasok")
        dg_pms.DataSource = DS.Tables("pemasok")
    End Sub

    Sub hapusbrg()
        Try
            Call koneksi()
            Dim str As String
            str = "delete from pemasok where Kodepms = '" & TextBox1.Text & "'"
            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data User Berhasil Dihapus.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox5.Text = ""
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
            dg_pms.Columns(4).Width = 70
            dg_pms.Columns(5).Width = 100
            dg_pms.Columns(0).HeaderText = "KODE PEMASOK"
            dg_pms.Columns(1).HeaderText = "NAMA PEMASOK"
            dg_pms.Columns(2).HeaderText = "ALAMAT"
            dg_pms.Columns(3).HeaderText = "NO TELP"
            dg_pms.Columns(4).HeaderText = "PERSON"
            dg_pms.Columns(5).HeaderText = "EMAIL"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dg_pms_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dg_pms.CellMouseClick
        TextBox1.Text = dg_pms.Rows(e.RowIndex).Cells(0).Value
        TextBox2.Text = dg_pms.Rows(e.RowIndex).Cells(1).Value
        TextBox3.Text = dg_pms.Rows(e.RowIndex).Cells(3).Value
        TextBox4.Text = dg_pms.Rows(e.RowIndex).Cells(4).Value
        TextBox5.Text = dg_pms.Rows(e.RowIndex).Cells(5).Value
        TextBox6.Text = dg_pms.Rows(e.RowIndex).Cells(2).Value

    End Sub

    Private Sub BtnSimpan_Click(sender As Object, e As EventArgs) Handles BtnSimpan.Click
        Call koneksi()
        Try
            Dim str As String
            str = "insert into pemasok values ('" & TextBox1.Text & "','" & TextBox2.Text & "', 
            '" & TextBox6.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', 
            '" & TextBox5.Text & "')"

            CMD = New MySql.Data.MySqlClient.MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Insert Data Pemasok Berhasil Dilakukan")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show("Insert data Pemasok gagal dilakukan.")
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
            str = "UPDATE pemasok SET Namapms = '" & TextBox2.Text & "', 
            Alamatpms = '" & TextBox6.Text & "', Teleponpms = '" & TextBox3.Text & "', 
            Personpms = '" & TextBox4.Text & "',
            Emailpms = '" & TextBox5.Text & "' WHERE Kodepms = '" & TextBox1.Text & "'"
            CMD = New MySqlCommand(str, CONN)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Update Data Pemasok Berhasil Dilakukan.")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub dg_pms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pms.CellContentClick

    End Sub
End Class