Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr(3) As String
        arr(0) = TxtNim.text
        arr(1) = TxtNama.Text
        arr(2) = CMBJK.Text
        arr(3) = CMBPRODI.Text
        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))

        TxtNim.Text = TxtNim.Text + 1
        TxtNama.Text = ""
        CMBJK.Text = ""
        CMBPRODI.Text = ""
        TxtNama.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr(3, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "MANAJEMEN HEHE"
        arr(3, 1) = "TEKNIK INFORMATIKA"

        ListView1.GridLines = True
        ListView1.View = View.Details
        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris
        For baris = 2 To 2
            For kolom = 0 To 1
                CMBJK.Items.Add(arr(baris, kolom))
            Next kolom
        Next
        For baris = 3 To 3
            For kolom = 0 To 1
                CMBPRODI.Items.Add(arr(baris, kolom))
            Next kolom
        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBJK.SelectedIndexChanged

    End Sub
End Class
