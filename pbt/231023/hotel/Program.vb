Imports System

Module Program
    Sub Main()
        Console.WriteLine("TOKO PAEDI")
        Console.WriteLine("======================")

        Dim a As Integer = 4000
        Dim b As Integer = 10000
        Dim c As Integer = 5500
        Dim totalbeli1 As Integer
        Dim totalbeli2 As Integer
        Dim totalbeli3 As Integer

        Console.Write("Total pensil yang dibeli: ")
        totalbeli1 = Convert.ToInt32(Console.ReadLine())
        Console.Write("Total penggaris yang dibeli: ")
        totalbeli2 = Convert.ToInt32(Console.ReadLine())
        Console.Write("Total buku yang dibeli: ")
        totalbeli3 = Convert.ToInt32(Console.ReadLine())

        Dim totalBiayaPensil As Integer = totalbeli1 * a
        Dim totalBiayaPenggaris As Integer = totalbeli2 * b
        Dim totalBiayaBuku As Integer = totalbeli3 * c

        Console.WriteLine("Barang yang Dibeli:")
        Console.WriteLine($"{totalbeli1} pack pensil")
        Console.WriteLine($"{totalbeli2} pack penggaris")
        Console.WriteLine($"{totalbeli3} pack buku")
        Console.WriteLine()

        If totalbeli1 >= 5 Then
            Console.WriteLine("Anda mendapatkan bonus!")
        End If

        Console.WriteLine("Total Biaya:")
        Console.WriteLine($"Pensil: {totalBiayaPensil.ToString("C0")}") ' Format sebagai mata uang
        Console.WriteLine($"Penggaris: {totalBiayaPenggaris.ToString("C0")}")
        Console.WriteLine($"Buku: {totalBiayaBuku.ToString("C0")}")

        Dim totalBiayaKeseluruhan As Integer = totalBiayaPensil + totalBiayaPenggaris + totalBiayaBuku
        Console.WriteLine("Total Biaya Keseluruhan: " & totalBiayaKeseluruhan.ToString("C0")) ' Format sebagai mata uang

        Console.ReadKey()
    End Sub
End Module
