Imports System

Module Program
    Sub Main()
        Dim nilai As Integer
        Dim grade As String

        Console.WriteLine("masukan nilai")
        nilai = Console.ReadLine()
        If nilai >= 90 And nilai <= 100 Then
            grade = "sangat memuaskan"
        ElseIf nilai >= 80 And nilai <= 89 Then
            grade = "baik"
        ElseIf nilai >= 65 And nilai <= 79 Then
            grade = "cukup baik"
        ElseIf nilai >= 50 And nilai <= 64 Then
            grade = "kurang baik"
        ElseIf nilai >= 0 And nilai <= 49 Then
            grade = "tidak lulus"
        Else
            grade = "nilai tidak valid"
        End If
        Console.WriteLine("nilai anda " + grade)
        Console.ReadKey()
    End Sub
End Module
