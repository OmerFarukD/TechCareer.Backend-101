// Mantıksal Operatörler

// ve (&&) -> Her 2 durumun olumlu olması sonucunda true döner.
// veya || -> Her 2 durumdan sadece 1 inin olumlu olması durumunda true döner.


bool dogruluk1= 3<5 && 4<1;
//             doğru veya yanlış 
Console.WriteLine(dogruluk1);

// if else blokları 
// kullanıcıdan hem bütçesini hem de yaşını alınız
// eğer bütçesi 500000 den fazla ve yaşı 18 den büyük eşitse
// Araba alabilir. Aksi takdirde araba alamaz

//Console.WriteLine("Lütfen bütçenizi giriniz :");
//double butce = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//int yas = Convert.ToInt32(Console.ReadLine());

//if (yas>=18 && butce>500000)
//{
//    Console.WriteLine("Araba alabilir.");
//}
//else
//{
//    Console.WriteLine("Araba Alamaz");
//}

// Kullanıcı notunu girdiği zaman 50 den düşük not alıyorsa
// harf notu F
//   56<Not<65  D
//   66<Not<75   C
//    76<Not<100  A

//Console.WriteLine("Lütfen notunuzu giriniz : ");
//int not = Convert.ToInt32(Console.ReadLine());

//if (not>0 && not<=55)
//{
//    Console.WriteLine("Harf Notunuz F");
//}else if (56<not && not<=65)
//{
//    Console.WriteLine("Harf Notunuz D");
//}
//else if(66<not && not <= 75)
//{
//    Console.WriteLine("Harf Notunuz C");
//}
//else if (76<not && not<=100)
//{
//    Console.WriteLine("Harf Notunuz A");
//}
//else
//{
//    Console.WriteLine("Yanlış karakter girdiniz.");
//}

// Metodlar 
// Değer döndüren ve değer döndürmeyen metodlar

// değer döndürmeyen metodlar : 

//SayHello("Ömer",22);
//SayHello("Cihat",23);
//SayHello("Gülsu",23);
//SayHello("İhsan", 23);
//SayHello("Buğra",25);
//SayHello(yas:25, isim:"Fatih");
Toplam(3,6);



void SayHello(string isim,int yas)
{
    Console.WriteLine($"Merhabalar {isim}, yaşınız :{yas}");
}


// Konsoldan 2 tane sayı alınacak ve aritmetik operatörlerde
// alınacak ve ilgili işlemi yapan fonksiyonlar çağrılacak
// 1. sayi -> 10
// 2. Sayi -> 20
// islem -> "+"
// Eğer + yı işaretlerse Topla(sayi1,sayi2);

//Console.WriteLine("Lütfen 1. Sayıyı giriniz :");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen 2. Sayıyı giriniz :");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Lütfen yapacağınız işlemi seçiniz :");
//Console.WriteLine("+ , - , /,*");
//char islem = Convert.ToChar(Console.ReadLine());

//if(islem == '+')
//{
//    Toplam(sayi1,sayi2);
//}
//else if (islem =='-')
//{
//    Fark(sayi1,sayi2);
//}
//else if (islem == '*')
//{
//    Carp(sayi1,sayi2);
//}
//else if (islem == '/')
//{
//    Bolme(sayi1,sayi2);
//}
//else
//{
//    Console.WriteLine("Yanlış karakter girdiniz.");
//}

string bilgi = KisiBilgileri("İhsan","Arslan",22);
Console.WriteLine(bilgi);

Console.WriteLine(KisiBilgileri("İhsan", "Arslan", 22));

Console.WriteLine(F(5.5,2.75));



void Toplam(int sayi1, int sayi2)
{
    Console.WriteLine($"{sayi1} + {sayi2} = {sayi1 + sayi2}");
}
void Fark(int sayi1, int sayi2)
{
    Console.WriteLine($"{sayi1} - {sayi2} = {sayi1 - sayi2}");
}
string KisiBilgileri(string isim, string soyisim, int yas)
{
    string sonuc = $"İsim :{isim} Soyisim : {soyisim}, Yaş : {yas}";
    return sonuc;
}
void Carp(int sayi1, int sayi2)
{
    Console.WriteLine($"{sayi1} * {sayi2} = {sayi1 * sayi2}");
}
void Bolme(int sayi1, int sayi2)
{
    Console.WriteLine($"{sayi1} / {sayi2} = {sayi1 / sayi2}");
}

double F(double m , double a)
{
    return m * a;
}


// F = m*a kütle * ivme di