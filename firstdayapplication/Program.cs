Console.WriteLine("Hello, World!");
Console.WriteLine(1 + 2);
string ad = "Aleyna";
Console.WriteLine(ad);
int sayi1 = 10;

int sayi2 = 15;
Console.WriteLine(sayi1);
Console.WriteLine(sayi2);
Console.WriteLine("1.sayı" + sayi1);
Console.WriteLine("2.sayı" + sayi2);
//2. yöntem string interpolation
Console.WriteLine($"1. Sayı :{sayi1}");
//double veri tipi
double sayi3 = 25;
Console.WriteLine(sayi3);
//Boolean veri tipi
bool dogruluk = false;
Console.WriteLine(dogruluk);

int number1 = 20;
int number2 = 60;
int sum = number1 + number2;
Console.WriteLine($"{number1} + {number2}={sum}");
int difference = number2 - number1;
Console.WriteLine($"{number2} - {number1}={difference}");
int divide = number2 / number1;
Console.WriteLine($"{number2} / {number1}={divide}");
//ondalıklı sayıyla çalışılıyorsa int yerine double kullanılmalı
double divide2 = number1 / number2;
Console.WriteLine($"{number1} / {number2}={divide2}"); //çalışmaz tüm değerler double atanmalı
int multiply = number1 * number2;
Console.WriteLine($"{number1} x {number2}={multiply}");
//mod olarak da kullanılır bu sayıların bölümünden kalandır
// double kullanıldığında sayı ondalıklı olarak da kullanılabilir
int mod = number2 % number1;
Console.WriteLine($"{number2} % {number1}={mod}");

int num3 = 10;
int num4 = 20;
Console.WriteLine($"{num3},{num4} ten büyük müdür = {num3>num4}");
//değer vererek hesaplatma kısmı
Console.WriteLine("1. sayıyı giriniz:");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("2. sayıyı giriniz:");
int numb2 = Convert.ToInt32(Console.ReadLine());
int top = numb1 + numb2;
Console.WriteLine("2 sayının toplamı=" + top);

int deger4 = 4;
int deger5 = 5;
int degersonuc = deger4 + deger5;
Console.WriteLine("iki sayının toplamı:" + degersonuc);



