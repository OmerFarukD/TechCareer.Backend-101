Console.WriteLine("Hello, World!");
// Arrays birden fazla değeri tutmamızı sağlayan bir yapıdır.
//int[] sayilar = {1,2,3,4,5,6,7,8,9,10};
////               0 1 2 3 4 5 6 7 8 9

//Console.WriteLine($"sayilar dizisinin boyutu : {sayilar.Length}");
//Console.WriteLine($"sayilar dizisinin en büyük elemanı : {sayilar.Max()}");
//Console.WriteLine($"sayilar dizisinin en küçük elemanı : {sayilar.Min()}");
//Console.WriteLine($"sayilar dizisindeki tüm elmanların toplamı : {sayilar.Sum()}");

// for veya foreach döngüleri
//for (int i=0; i<=sayilar.Length;i+=1)
//{
//    Console.WriteLine(sayilar[i]);
//}

//foreach (int sayi in sayilar)
//{
//    Console.WriteLine(sayi);
//}

// List 
// Referans tipler kendi olş. classlar, diziler, listeler,Hashmap,Interface vs vs
List<string> sehirler = new List<string>()
{
    "İstanbul","Ankara","Adana","İzmir"
};

sehirler.Add("Malatya");
sehirler.Add("Bingöl");
Console.WriteLine($"şehirler listesinde kaç eleman var : {sehirler.Count}");
Console.WriteLine($"sehirler listesinde Ankara var mı : {sehirler.Contains("Ankara")}");
Console.WriteLine($"şehirler listesinin tipi : {sehirler.GetType()}");
Console.WriteLine(sehirler[2]);
//foreach (string sehir in sehirler)
//{
//    Console.Write(sehir + ", ");
//}
//Console.WriteLine();

sehirler.ForEach(x=> Console.Write(x + ", "));
Console.WriteLine();

// Bir listede 1 den 10 a kadar tüm sayılar bulunsun
// 2 tane daha liste oluşturun ve bu listeler tek sayılar ve çift sayıları tutsun

List<int> sayilar = new List<int>() {1,2,3,4,5,6,7,8,9,10};
List<int> cift_sayilar = new List<int>();
List<int> tek_Sayilar = new List<int>();

//1. Yöntem
//foreach (int sayi in sayilar)
//{
//    if(sayi %2 == 0)
//    {
//        cift_sayilar.Add(sayi);
//    }
//    else
//    {
//        tek_Sayilar.Add(sayi);
//    }

//}

//Console.WriteLine("Çift sayılar : ");
//EkranaYazdir(cift_sayilar);

//Console.WriteLine("Tek sayılar :");
//EkranaYazdir(tek_Sayilar);

//2. Yöntem
cift_sayilar = sayilar.FindAll(x=>x%2==0);
tek_Sayilar = sayilar.FindAll(x=> x%2==1);
Console.WriteLine("Çift sayılar : ");
EkranaYazdir(cift_sayilar);

Console.WriteLine("Tek sayılar :");
EkranaYazdir(tek_Sayilar);



void EkranaYazdir(List<int> numbers)
{
    //1. Yöntem
    numbers.ForEach(x => Console.WriteLine(x));

    //2. Yöntem
    //foreach(int number in numbers)
    //{
    //    Console.WriteLine(number);
    //}
}
// Dictionary 
Dictionary<string,double> urunFiyatlari = new Dictionary<string,double>();
urunFiyatlari.Add("Elma", 25);
urunFiyatlari.Add("Armut", 35);
urunFiyatlari.Add("Kiraz", 15);
urunFiyatlari.Add("Karpuz", 5);

foreach (KeyValuePair<string,double> eleman in urunFiyatlari)
{
    Console.WriteLine($"Ürün adı : {eleman.Key}, Ürünün Değeri : {eleman.Value}");
}
Console.WriteLine($"Kirazın fiyatı : {urunFiyatlari["Kiraz"]}");
