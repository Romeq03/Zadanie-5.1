using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj nazwę miasta: ");
        string nazwaMiasta = Console.ReadLine();

        Console.Write("Podaj nazwę województwa: ");
        string nazwaWojewodztwa = Console.ReadLine();

        int dlugoscMiasta = nazwaMiasta.Length;
        int dlugoscWojewodztwa = nazwaWojewodztwa.Length;

        Console.WriteLine($"Nazwa miasta {nazwaMiasta} zawiera {dlugoscMiasta} liter.");
        Console.WriteLine($"Nazwa województwa {nazwaWojewodztwa} zawiera {dlugoscWojewodztwa} liter.");

        Console.ReadLine();
    }
}
