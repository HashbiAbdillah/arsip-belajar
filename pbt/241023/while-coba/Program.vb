Imports System

Module Program
    Sub Main()
        Dim angka As Integer

        While angka < 10
            '("tampilkan angka: " + angka)
            Console.WriteLine("angka ke " & angka)
            angka = angka + 1
        End While
        Console.ReadLine()

    End Sub
End Module
