Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputText As String = TextBox1.Text
        Dim angkaStr() As String = inputText.Split(" "c)
        Dim angka(angkaStr.Length - 1) As Integer

        ' Mengonversi string menjadi angka integer
        For i As Integer = 0 To angkaStr.Length - 1
            angka(i) = Convert.ToInt32(angkaStr(i))
        Next

        ' Melakukan pengurutan menggunakan Bubble Sort
        For i As Integer = 0 To angka.Length - 2
            For j As Integer = 0 To angka.Length - 2 - i
                If angka(j) > angka(j + 1) Then
                    Dim temp As Integer = angka(j)
                    angka(j) = angka(j + 1)
                    angka(j + 1) = temp
                End If
            Next
        Next

        ' Menampilkan hasil pengurutan di TextBox atau MessageBox
        TextBox2.Text = "Angka setelah diurutkan: " & String.Join(" ", angka)
    End Sub
End Class
