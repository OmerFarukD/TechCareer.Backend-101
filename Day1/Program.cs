Console.WriteLine(55+101);

// int : Tam sayıların tutulduğu bir veri tipidir.
int sayi1 = 55;
int sayi2 = 201;
Console.WriteLine(sayi1+sayi2);

// string : metinsel değerleri tuttuğumuz bir veri tipidir.
string metin1 = "Bu eğitimin ilk günüdür.";
//Console.WriteLine(metin1);

string metin2 = " Konumuz .net 101";
string sonuc = metin1 + metin2;

Console.WriteLine(sonuc);

// 2 tane sayıyı toplayıp ekrana bastıran kodu yazınız.
int number1 = 150;
int number2 = 100;
int toplam = number1 + number2;
Console.WriteLine("iki sayının toplamı : "+ (number1+number2));

// Kullanıcıdan isim soyisim yaş aldıktan sonra ekrana basmasını isteyelim.

//Console.WriteLine("Lütfen adınızı giriniz: ");
//string ad = Console.ReadLine();

//Console.WriteLine("Lütfen soyadınızı giriniz : ");
//string soyad = Console.ReadLine();

//Console.WriteLine("Lütfen yaşınızı giriniz : ");
//int yas = Convert.ToInt32(Console.ReadLine());

////1. Yöntem
//Console.WriteLine("ad :"+ad+" soyad: "+soyad+" yaş: "+yas);

//// 2. Yöntem String Interpolation
//Console.WriteLine($"ad : {ad} soyad : {soyad} yaş : {yas}");

// Yorum satırı kısayolu Ctrl + k + c

// double veri tipi : ondalıklı sayıları ifade eder.
double ondalik1 = 10.5;
double ondalik2 = 10.25;
Console.WriteLine(ondalik1+ondalik2);

// char : tek karakterli metinsel değerleri tutar.


char a = 'a';
Console.WriteLine((int)a);

// 10/3 = 10 bölünen , 3 bölen , 3 bölüm, 1 kalan

// Aritmetik operatorler

double nm1 = 10;
double nm2 = 3;

Console.WriteLine($" {nm1} + {nm2} = {nm1+nm2}");
Console.WriteLine($" {nm1} - {nm2} = {nm1 - nm2}");
Console.WriteLine($" {nm1} * {nm2} = {nm1 * nm2}");
Console.WriteLine($" {nm1} / {nm2} = {nm1 / nm2}");
Console.WriteLine($"{nm1} in {nm2} ye bölümünden kalan = {nm1%nm2}");

// Karşılaştırma operatörleri 
// Bool veri tipi : Doğru veya yanlış ifaedelerini temsil eden veri tipidir.
// < küçüktür
//  > büyüktür
//  <= küçük eşittir
//  >= büyük eşittir
//  == eşittir
//  != eşit değildir

bool bool1 = 3 < 1;
bool bool2 = 3 > 1;
bool bool3 = 3 == 1;
bool bool4 = 3 != 1;
bool bool5 = false;
bool bool6 = true;

Console.WriteLine(bool1);
Console.WriteLine(bool2);
Console.WriteLine(bool3);
Console.WriteLine(bool4);
Console.WriteLine(bool5);
Console.WriteLine(bool6);
