import 'dart:io';
void main(){
 stdout.write("isikan nama anda : ");
  var nama = stdin.readLineSync();

  stdout.write("isikan kelas anda : ");
  var kelas = stdin.readLineSync();

  stdout.write("isikan nomor urut absen : ");
  var absen = stdin.readLineSync();

  stdout.write("isikan nilai PPB : ");
  int nilaiPPB = int.parse(stdin.readLineSync()!);

  print('Nama : $nama');
  print('Kelas : $kelas');
  print('Absen : $absen');

  if (nilaiPPB >= 78){
    print("anda lulus");
  } else {
    print("anda harus remedial");
  }

  for (var i = 10; i <= 55; i += 9){
    print('Absen saat ini : $i');
  }
}