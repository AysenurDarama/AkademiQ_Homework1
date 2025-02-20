//1.soru
Console.WriteLine("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 0)
{
    Console.WriteLine("Sayı sıfır.");
}
else if (number < 0)
{
    Console.WriteLine("Sayı negatif.");
}
else
{
    Console.WriteLine("Sayı pozitif");
}

//2.soru
Console.Write("Bir 1 ile 7 arasında bir sayı girin: ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz bir sayi girdiniz!");
        break;

}

//3.Soru
Console.WriteLine("--Basit Hesap Makinesi--\n");

Console.WriteLine("1-Toplama'+'\n2-Çıkarma'-'\n3-Çarpma'*'\n4-Bölme'/'\n");

Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz: ");
string islem = Console.ReadLine();

Console.Write("1.sayıyı giriniz: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("2.sayıyı giriniz: ");
double num2 = Convert.ToDouble(Console.ReadLine());

switch (islem)
{
    case "+":
        Console.WriteLine(num1 + num2);
        break;

    case "-":
        Console.WriteLine(num1 - num2);
        break;

    case "*":
        Console.WriteLine(num1 * num2);
        break;

    case "/":
        if (num2 != 0)
        {
            Console.WriteLine(num1 / num2);
        }
        else
        {
            Console.WriteLine("Sayı sıfıra bölünemez.");
        }
        break;
    default:
        Console.WriteLine("Geçersiz işlem!");
        break;
}

//4.Soru
Console.Write("Birinci sayıyı giriniz: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("İkinci sayıyı giriniz: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Üçüncü sayıyı giriniz: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum;
maxNum = num1;

if (num2 > maxNum)
{
    maxNum = num2;
}
else if (num3 > maxNum)
{
    maxNum = num3;
}
Console.Write("En büyük sayı: " + maxNum);

//5.Soru
Console.Write("Lütfen şifrenizi giriniz: ");
string password = Console.ReadLine();

bool specialChar = false;
bool upperCase = false;

if (password.Length < 8)
{
    Console.WriteLine("Şifre en az 8 karakter olmalı!");
}
else
{
    foreach (char c in password)
    {
        if (c == '@' || c == '#' || c == '$' || c == '%')
        {
            specialChar = true;
        }
        if (char.IsUpper(c))
        {
            upperCase = true;
        }
    }
    if (specialChar && upperCase)
    {
        Console.WriteLine("Şifreniz güçlü.");
    }
    else
    {
        if (!specialChar)
        {
            Console.WriteLine("Şifre özel karakter içermeli!");
        }
        if (!upperCase)
        {
            Console.WriteLine("Şifre büyük harf içermeli!");
        }
    }
}
