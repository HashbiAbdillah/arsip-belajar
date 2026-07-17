Imports System
Imports System.Net

Module Program
    Sub Main()
        Console.WriteLine("simple kalkulator")
        Dim a As Double
        Dim b As Double
        Dim hasiltambah As Integer
        Dim hasilkurang As Integer
        Dim hasilkali As Integer
        Dim hasilbagi As Double
        Dim modulus As Integer
        Dim dive As Integer

        Console.Write("bilangan 1: ")
        a = Console.ReadLine()
        Console.Write("bilangan 2: ")
        b = Console.ReadLine()


        hasiltambah = a + b
        Console.Write("hasil tambah adalah ")
        Console.Write(hasiltambah)
        Console.ReadLine()

        hasilkurang = a - b
        Console.Write("hasil kurang adalah ")
        Console.Write(hasilkurang)
        Console.ReadLine()

        hasilkali = a * b
        Console.Write("hasil kali adalah ")
        Console.Write(hasilkali)
        Console.ReadLine()


        hasilbagi = a / b
        Console.Write("hasil bagi adalah ")
        Console.Write(hasilbagi)
        Console.ReadLine()

        dive = a \ b
        Console.Write("hasil div adalah ")
        Console.Write(dive)
        Console.ReadLine()

        modulus = a Mod b
        Console.Write("hasil modulus adalah ")
        Console.Write(modulus)
        Console.ReadKey()
    End Sub
End Module
