// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int result = 1;

for (int i = 1; i < 5; i++)
{
    result = result * 3;
}


Console.WriteLine(result);


Islemler instance = new Islemler();
Console.WriteLine(instance.Expo(3, 4));


string s = "string string";
bool sonuc = s.CheckSpace();


Console.WriteLine(sonuc);

if (sonuc)
{
    Console.WriteLine(s.RemoveWhiteSpaces());
}

Console.WriteLine(s.MakeUpperCase());
Console.WriteLine(s.MakeLowerCase());

int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };

dizi.SortArray();

dizi.EkranaYazdir();

int sayi = 5;

Console.WriteLine(sayi.IsEven());

Console.WriteLine(s.GetFirstChar());


// Console.ReadLine();


public class Islemler
{

    public int Expo(int x, int y)
    {
        if (y < 2)
        {
            return x;
        }
        return Expo(x, y - 1) * x; }

    }

public static class Extension
{
    public static bool CheckSpace(this string p)
    {
        return p.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string p)
    {
        string[] dizi = p.Split(" ");
        return string.Join("", dizi);

    }


    public static string MakeUpperCase(this string p)
    {
        return p.ToUpper();
    }

    public static string MakeLowerCase(this string p)
    {
        return p.ToLower();
    }

    public static int[] SortArray(this int[] arr)
    {
       Array.Sort(arr);
        return arr;
    }


    public static void EkranaYazdir(this int[] p)
    {
        foreach (int i in p)
        {
            Console.WriteLine(i);
        }
    }

    public static bool IsEven(this int i)
    {
        return i % 2 == 0;
    }

    public static string GetFirstChar(this string p)
    {
        return p.Substring(0, 1);
    }





}
