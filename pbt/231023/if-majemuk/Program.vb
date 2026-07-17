Imports System

Module Program
    Sub Main()
        Dim hari As String

        Console.WriteLine("bagaimana cuaca hari ini?")
        hari = Console.ReadLine()
        If hari = "hujan" Then
            Console.WriteLine("saya akan membawa payung")
        ElseIf hari = "panas" Then
            Console.WriteLine("saya akan membawa topi")
        ElseIf hari = "mendung" Then
            Console.WriteLine("saya akan membawa jaket")
        Else
            Console.WriteLine("ywdh sih")
        End If
        Console.ReadKey()
    End Sub
End Module
