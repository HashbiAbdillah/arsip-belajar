Public Class Form1
    Dim hasil As Double

    Private Function akar()
        Return Math.Sqrt(Val(TextBox1.text))
    End Function

    Private Function pangkat()
        Return Math.Pow((TextBox1.Text), Val(TextBox2.Text))
    End Function

    Private Function pembagian()
        Return Val(TextBox1.Text) / Val(TextBox2.Text)
    End Function

    Private Function perkalian()
        Return Val(TextBox1.Text) * Val(TextBox2.Text)
    End Function

    Private Function pengurangan()
        Return Val(TextBox1.Text) - Val(TextBox2.Text)
    End Function

    Private Function penjumlahan()
        Return Val(TextBox1.Text) + Val(TextBox2.Text)
    End Function

    Private Function hasilakar()
        hasil = akar()
        Return hasil
    End Function

    Private Function hasilpangkat()
        hasil = pangkat()
        Return hasil
    End Function

    Private Function hasilbagi()
        hasil = pembagian()
        Return hasil
    End Function
    Private Function hasilkali()
        hasil = perkalian()
        Return hasil
    End Function
    Private Function hasilkrg()
        hasil = pengurangan()
        Return hasil
    End Function
    Private Function hasiljml()
        hasil = penjumlahan()
        Return hasil
    End Function
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            hasilakar()
        ElseIf RadioButton2.Checked Then
            hasilpangkat()
        ElseIf RadioButton3.Checked Then
            hasilbagi()
        ElseIf RadioButton4.Checked Then
            hasilkali()
        ElseIf RadioButton5.Checked Then
            hasiljml()
        ElseIf RadioButton6.Checked Then
            hasilkrg()
        End If
        TextBox3.Text = hasil.ToString
    End Sub
End Class
