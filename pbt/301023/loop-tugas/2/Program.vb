Imports System

Module Program
    Sub Main()
        Console.WriteLine("Menampilkan angka ganjil dari 1 sampai 10:")
        For i As Integer = 1 To 10
            If i Mod 2 = 1 Then
                Console.WriteLine(i)
            End If
        Next
        Console.ReadKey()
    End Sub
End Module
