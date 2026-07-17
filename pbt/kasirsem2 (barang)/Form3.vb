Public Class Form3
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub BARANGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BARANGToolStripMenuItem.Click
        barang.Show()
    End Sub

    Private Sub PEMASOKToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMASOKToolStripMenuItem.Click
        pemasok.Show()
    End Sub

    Private Sub PELANGGANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PELANGGANToolStripMenuItem.Click
        pelanggan.Show()
    End Sub


    Private Sub PEMAKAIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PEMAKAIToolStripMenuItem.Click
        pemakai.Show()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EXITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EXITToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub PENERIMAANToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PENERIMAANToolStripMenuItem.Click
        penerimaan.Show()
    End Sub

    Private Sub DETAILTERIMAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETAILTERIMAToolStripMenuItem.Click
        detailterima.Show()
    End Sub

    Private Sub PENJUALANToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PENJUALANToolStripMenuItem1.Click
        Penjualan.Show()
    End Sub

    Private Sub TRANSAKSIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TRANSAKSIToolStripMenuItem.Click

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LOGOUTToolStripMenuItem.Click
        lojin.Show()
        Me.Close()
    End Sub

    Private Sub DETAILJUALToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DETAILJUALToolStripMenuItem.Click
        detailjual.Show()
    End Sub
End Class