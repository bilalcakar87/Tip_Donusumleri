// See https://aka.ms/new-console-template for more information

// Implicit Conversion (Bilinsiz Dönüşüm)
Console.WriteLine("*******Implicit Conversion*******");
byte a = 5;
sbyte b =30;
short c = 10;

int d = a+b+c;
Console.WriteLine("d:"+d);

long h = d;
Console.WriteLine("h:" +h);

float i =h;
Console.WriteLine("i:" + i);

string e ="Bilal";
char f = 'e';
object g= e+f+d;
Console.WriteLine("g: " + g);


//Explicit Conversion (Bilinçli Dönüşüm)

Console.WriteLine("*******Explicit Conversion*******");

int x =4;
byte y = (byte)x;
Console.WriteLine("y:" +y);

int z = 100;
byte t =(byte)z;
Console.WriteLine("t:" +t);

//float w = 10,3f;     Bnm sürümde değer vermiyor
//byte v = (byte)w;
//Console.WriteLine("v: " + v);



// toString Methodu
Console.WriteLine("****** toString Methodu********");
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy: " + yy);

//string zz = 12,5f.toString();
//Console.WriteLine("zz :" + z);

// System.Convert 
Console.WriteLine("****** System.Convert sınıfı******");
string s1="10", s2="20";
int sayi1,sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1 +sayi2;
Console.WriteLine("Toplam: " + Toplam);

//Parese
Console.WriteLine("***********Parse Methodu*************");
//ParseMethod(); 
 
//public static void ParseMethod{}
{
string metin1 ="10";
string metin2 = "10,25";
int rakam1;
double double1;

rakam1 = Int32.Parse(metin1);
double1 =double.Parse(metin2);

Console.WriteLine("rakam1: "+ rakam1);
Console.WriteLine("double1: " +  double1);


}


// //olarak alınmış olanlar derslerde anlatılıp sonuç alınmış code lar fakat anlatıcı farklı bi debug mı kullanıyo farklı bi durum mu var algılayamadım son surum kullandığım için versiyon farklarından mıdır ondan emin olamdığım için bir bilene sorana kadar sunum bu malesef ama standart C# visual da çalışan codelardır çoğu...