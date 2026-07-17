Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("harga sewa kamar")
        Dim a As Integer
        Dim b As Integer
        Dim nama As String
        ' Dim hasiltambah As Integer
        Dim kembalian As Integer
        Dim totalharga As Integer
        Dim c As Integer
        'Dim hasilbagi As Double

        Console.Write("Nama penyewa: ")
        nama = Console.ReadLine()
        Console.Write("harga sewa: ")
        a = Console.ReadLine()
        Console.Write("lama menginap: ")
        b = Console.ReadLine()


        'hasiltambah = a + b
        'Console.Write("hasil tambah adalah ")
        'Console.Write(hasiltambah)
        'Console.ReadLine()
        totalharga = a * b
        Console.Write("total harga yang harus dibayar tuan " + nama + " ")
        Console.Write(totalharga)
        Console.ReadLine()

        Console.Write("nilai uang untuk dibayar ")
        c = Console.ReadLine()

        kembalian = c - totalharga
        Console.Write("kembalian ")
        Console.Write(kembalian)
        Console.ReadLine()
        Console.Write("terimakasih sudah menginap :)")
        Console.ReadLine()


        'hasilbagi = a / b
        ' Console.Write("hasil bagi adalah ")
        'Console.Write(hasilbagi)
        'console.ReadKey()
    End Sub
End Module
