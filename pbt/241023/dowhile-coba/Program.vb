Imports System

Module Program
    Sub Main()
        Dim angka As Integer
        angka = 1
        Do While angka <= 10
            '("tampilkan angka: " + angka)
            Console.WriteLine("angka ke " & angka)
            angka = angka + 1
        Loop
        Console.ReadLine()

    End Sub
End Module
