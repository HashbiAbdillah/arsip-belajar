Imports System

Module Program
    Sub Main(Args As String())
        Console.WriteLine("TOKO PAEDI")
        Console.WriteLine("======================")

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer = 4000
        Dim f As Integer = 10000
        Dim g As Integer = 5500
        Dim hargapensil As Integer
        Dim hargapenggaris As Integer
        Dim hargabuku As Integer
        Dim totalharga As Integer
        Dim totalbarang As Integer
        Dim kembalian As Integer

        Console.Write("Pensil (pack):")
        a = Console.ReadLine()
        hargapensil = e * a
        Console.WriteLine(hargapensil)

        Console.Write("Penggaris: ")
        b = Console.ReadLine()
        hargapenggaris = f * b
        Console.WriteLine(hargapenggaris)

        Console.Write("Buku (pack): ")
        c = Console.ReadLine()
        hargabuku = g * c
        Console.WriteLine(hargabuku)
        Console.ReadLine()

        If a >= 5 Then
            Console.WriteLine("Selamat anda mendapatkan bonus 1 Tempat Pensil !!")
        Else
            Console.WriteLine("maaf anda tidak mendapat bonus")
        End If

        Console.WriteLine("Total barang : ")
        totalbarang = a + b + c
        Console.WriteLine(totalbarang)
        Console.ReadLine()

        Console.WriteLine("Total harga : ")
        totalharga = hargapensil + hargapenggaris + hargabuku
        Console.WriteLine(totalharga)
        Console.ReadLine()

        Console.Write("Uang yang diberikan pelanggan : ")
        d = Console.ReadLine()

        kembalian = d
        Console.Write("Uang kembalian : ")
        kembalian = d - totalharga
        Console.Write(kembalian)
        Console.ReadLine()


    End Sub
End Module
