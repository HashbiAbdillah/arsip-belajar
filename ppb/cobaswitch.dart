import 'dart:io';

void main(){
  print("masukan angka 1-3");
var tombol = int.parse(stdin.readLineSync()!);  
switch (tombol) {
  case 1:
    print("matikan lampu");
    break;
  case 2:
    print("turunkan harga beras");
    break;
  case 3:
   print('naikan harga motor listrik');
   break;
}

}