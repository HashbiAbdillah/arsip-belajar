Imports System

Module Program
    Sub Main()
        Dim hari As String

        Console.WriteLine("bagaimana cuaca hari ini?")
        hari = Console.ReadLine()
        Select Case hari
            Case Is = "hujan"
                Console.WriteLine("saya akan membawa payung")
            Case Is = "panas"
                Console.WriteLine("saya akan membawa topi")
            Case Is = "mendung"
                Console.WriteLine("saya akan membawa jaket")
            Case Else
                Console.WriteLine("ywdh sih")
        End Select

        Console.ReadKey()
    End Sub
End Module
