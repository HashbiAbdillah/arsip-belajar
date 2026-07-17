Imports System

Module Program
    Sub Main()

        Console.Write("Masukkan jumlah banyaknya nilai yang akan dihitung rata-ratanya: ")
        Dim n As Integer = Convert.ToInt32(Console.ReadLine())
        Dim nilai(n - 1) As Double

        For i As Integer = 0 To n - 1
            Console.Write("Masukkan nilai ke-" & (i + 1) & ": ")
            nilai(i) = Convert.ToDouble(Console.ReadLine())
        Next

        Console.WriteLine("Nilai yang telah diinput: " & String.Join(", ", nilai))

        Dim rataRata As Double = nilai.Average()

        Console.WriteLine("Rata-rata nilai: " & rataRata)
        Console.ReadKey()

    End Sub
End Module