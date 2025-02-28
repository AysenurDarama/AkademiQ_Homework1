//1.Soru
Console.Write("Bir sayı giriniz: ");
int num = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = num; i > 0; i /= 10)
{
    sum += i % 10;
}
Console.WriteLine("Rakamlar toplamı: " + sum);

//2.Soru
int num;
while (true)
{
    Console.Write("10 ile 100 arsında bir sayı giriniz: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num >= 10 && num <= 100)
    {
        Console.WriteLine("Geçerli sayı: " + num);
        break;
    }
    else
    {
        Console.WriteLine("Geçersiz sayı! 10 ile 100 arasında bir sayı giriniz: ");
    }
}

//3.Soru
List<int> ages = new List<int> { 6, 12, 20, 25, 30, 45, 56, 60, 65, 79 };

foreach (int age in ages)
{
    string kategori = "";

    if (age >= 0 && age <= 12)
    {
        kategori = "Çocuk";
    }
    else if (age >= 13 && age <= 19)
    {
        kategori = "Genç";
    }
    else if (age >= 20 && age <= 64)
    {
        kategori = "Yetişkin";
    }
    else if (age >= 65)
    {
        kategori = "Yaşlı";
    }

    Console.WriteLine($"Yaş: {age} , Kategori: {kategori}");
}

//4.Soru
int[] elemanlar = { 10, 20, 30, 20, 40, 50, 60, 80, 40, 50 };

for (int i = 0; i < elemanlar.Length; i++)
{
    for (int j = i + 1; j < elemanlar.Length; j++)
    {
        if (elemanlar[i] == elemanlar[j])
        {
            Console.WriteLine($"{elemanlar[i]} sayısı tekrara ediyor.");
            break;
        }
    }
}

//5.Soru
string[] kelimeler = { "bu", "gün", "hava", "bulutlu" };

string enUzun = kelimeler[0];
string enKısa = kelimeler[0];

for (int i = 0; i < kelimeler.Length; i++)
{
    if (kelimeler[i].Length > enUzun.Length)
    {
        enUzun = kelimeler[i];
    }
    if (kelimeler[i].Length < enKısa.Length)
    {
        enKısa = kelimeler[i];
    }

}
Console.WriteLine("En uzun kelime: " + enUzun);
Console.WriteLine("En kısa kelime: " + enKısa);

//6.Soru
Console.Write("Bir cümle giriniz: ");
string cumle = Console.ReadLine();

string[] kelimeler = cumle.Split(' ');

Array.Sort(kelimeler);

Console.WriteLine("Alfabetik olarak sıralanmış kelimeler: ");
foreach (string kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

//7.Soru
string[] kelimeler = new string[3];
kelimeler[0] = "Bu";
kelimeler[1] = "Hafta";
kelimeler[2] = "Ders";

int yeniBoyut = kelimeler.Length + 1;
string[] yeniDizi = new string[yeniBoyut];

for (int i = 0; i < kelimeler.Length; i++)
{
    yeniDizi[i] = kelimeler[i];
}

yeniDizi[yeniBoyut - 1] = "Yok";

Console.WriteLine("Yeni dizi elemanları:");
foreach (var kelime in yeniDizi)
{
    Console.WriteLine(kelime);
}

//8.Soru
List<string> kelimeler = new List<string>();
string kelime;

Console.Write("Kelimeleri girin: ");

while (true)
{
    kelime = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(kelime))
    {
        break;
    }

    kelimeler.Add(kelime);
}
kelimeler.Reverse();

foreach (var k in kelimeler)
{
    Console.WriteLine(k);
}

//9.soru
Console.Write("Girmek istediğiniz sayı adedini yazınız: ");
int adet = Convert.ToInt32(Console.ReadLine());
double toplam = 0;
List<double> sayilar = new List<double>();

Console.WriteLine("\n");
for (int i = 0; i < adet; i++)
{
    Console.Write($"{i + 1}.sayıyı giriniz: ");
    double sayi = Convert.ToDouble(Console.ReadLine());
    toplam += sayi;
    sayilar.Add(sayi);
}

Console.WriteLine("\n");
double ortalama = toplam / adet;
Console.WriteLine("Sayıların ortalaması: " + ortalama + "\n");

sayilar.Sort();
Console.Write("Sıralanmış Liste: ");
foreach (double S in sayilar)
{
    Console.Write("\t" + S);
}

//10.Soru
List<int> sayilar = new List<int> { 1, 5, 3, 7, 10, 12, 14, 25, 45, 56, 58 };
Console.Write("İlk liste: ");
foreach (int sayi in sayilar)
{
    Console.Write(sayi + "\t");
}
Console.WriteLine("\n");
sayilar.RemoveAll(sayi => sayi < 10);

Console.Write("Son liste: ");
foreach (int sayi in sayilar)
{
    Console.Write(sayi + "\t");
}

//11.Soru
List<double> notlar = new List<double> { 10, 25, 35, 40, 43, 42.5, 65, 70, 80 };
for (int i = 0; i < notlar.Count; i++)
{
    if (notlar[i] < 50)
    {
        notlar[i] = 50;
    }
}
foreach (double not in notlar)
{
    Console.WriteLine(not);
}