Imports System

Module Program
    Sub Main(args As String())
        Dim hari As String

        Console.WriteLine("bagaimana cuaca hari ini?")
        hari = Console.ReadLine()
        If hari = "hujan" Then
            Console.WriteLine("saya akan membawa payung")
        Else
            Console.WriteLine("ywdh sih")
        End If
        Console.ReadKey()
    End Sub
End Module
