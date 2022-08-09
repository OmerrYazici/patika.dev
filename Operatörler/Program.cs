// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Değişken Tanımlaması:
int x = 2021, y = 5, z = 8;
string webSite = "www.emrecelen.com.tr", webText = "Web Sitem: ";
//Aritmetik Operatör Kullanımları:
Console.WriteLine(new string ('-',20)+"\n-> C# Aritmetik Operatör Örnekleri");
Console.WriteLine("-> X + Y = " + (x + y) + "\t- Toplama Operatörü"); // Toplama Operatör Kullanımı
Console.WriteLine("-> Z - X = " + (z - x) + "\t- Çıkartma Operatörü"); // Çıkartma Operatör Kullanımı
Console.WriteLine("-> Z * Y = " + (z * y) + "\t- Çarpma Operatörü"); // Çarpma Operatör Kullanımı
Console.WriteLine("-> X / Y = " + (x / y) + "\t- Bölme Operatörü"); // Bölme Operatör Kullanımı
Console.WriteLine("-> X % Y = " + (x % y) + "\t- Mod Alma Operatörü"); // Mod Alma Operatör Kullanımı
Console.WriteLine(new string('-', 20));
Console.WriteLine(webText + webSite); // String metinleri birleştirme için (+) operatör kullanımı
 // Değişken Tanımlaması:
int a = 5, b = 5, x = 10, y = 10;
bool neyimBen = true;
// Tekli Operatör Kullanımı:
Console.WriteLine(new string('-', 20)+"\n-> Başlangıç (A) Değeri: {0} -- Başlangıç (B) Değeri: {1}",a,b);
Console.WriteLine("-> (A++) Kullanımı: {0} -- (++B) Kullanımı: {1}", a++, ++b);
Console.WriteLine(new string('-', 20) + "\n-> Başlangıç (X) Değeri: {0} -- Başlangıç (Y) Değeri: {1}", x, y);
Console.WriteLine("-> (X--) Kullanımı: {0} -- (--Y) Kullanımı: {1}", x--, --y);
Console.WriteLine(new string('-', 20) + "\n-> Başlangıç (neyimBen) Değeri: " + neyimBen);
Console.WriteLine("-> (!neyimBen) Kullanımı:" + !neyimBen);
Console.WriteLine(new string('-', 20));
// Değişken Tanımlaması:
int degisken = 15;
// Atama Operatör Kullanımı:
Console.WriteLine(new string('-', 20) + "\n-> C# Atama Operatör Örnekleri");
Console.WriteLine("-> [{0}] degisken += 5 Sonucu: {1}",degisken, (degisken += 5));
Console.WriteLine("-> [{0}] degisken -= 12 Sonucu: {1}", degisken, (degisken -= 12));
Console.WriteLine("-> [{0}] degisken *= 2 Sonucu: {1}", degisken, (degisken *= 2));
Console.WriteLine("-> [{0}] degisken /= 4 Sonucu: {1}", degisken, (degisken /= 4));
Console.WriteLine(new string('-', 20));
// Değişken Tanımlaması:
string kAdi, pass;
string kullaniciAdi = "ömer", sifre = "123";
Console.WriteLine(new string('-', 20) + "\n-> C# Mantıksal Operatör Örneği");
Console.Write("-> Kullanıcı Adını Girin: ");
kAdi = Console.ReadLine();
Console.Write("-> Şifrenizi Girin: ");
pass = Console.ReadLine();
Console.WriteLine(new string('-', 20));
if (kullaniciAdi.Equals(kAdi) && sifre.Equals(pass))
Console.WriteLine("-> Giriş Başarılı.");
else
Console.WriteLine("-> Hatalı Giriş Yaptınız.");
Console.WriteLine(9<<2); // 36 Olarak Ekrana Çıktı Gösterir.
Console.WriteLine(9>>2); // 2 Olarak Ekrana Çıktı Gösterir.