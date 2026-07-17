Imports System

Module Program
    Sub Main()
        Dim hari As String

        Console.WriteLine("bagaimana cuaca hari ini?")
        hari = Console.ReadLine()
        If hari = "hujan" Then
            Console.WriteLine("saya akan membawa payung")
        End If
        Console.ReadKey()

    End Sub
End Module
