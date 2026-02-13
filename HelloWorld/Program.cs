using System;

public class Rechner
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Taschenrechner ===");

        Console.Write("Erste Zahl: ");

        double zahl1;
        
        bool ok = double.TryParse(Console.ReadLine(), out zahl1);
        if (ok)
        {
            Console.WriteLine($"Sie haben {zahl1} eingegeben");
        }
        else 
        {
            Console.WriteLine("Das ist nicht Zahl!");
        }

            Console.Write("Operation (+, -, *, /): ");
        string operation = Console.ReadLine();

        Console.Write("Zweite Zahl: ");

        double zahl2;

        bool ok1 = double.TryParse(Console.ReadLine(), out zahl2);
        if (ok1)
        {
            Console.WriteLine($"Sie haben {zahl2} eingegeben");
        }
        else
        {
            Console.WriteLine("Das ist nicht Zahl!");
        }

        double ergebnis = 0;

        if (operation == "+")
        {
            ergebnis = zahl1 + zahl2;
        }
        else if (operation == "-")
        {
            ergebnis = zahl1 - zahl2;
        }
        else if (operation == "*")
        {
            ergebnis = zahl1 * zahl2;
        }
        else if (operation == "/")
        {
            if (zahl2 != 0)
            {
                ergebnis = zahl1 / zahl2;
            }
            else
            {
                Console.WriteLine("Fehler: Division durch Null!");
                return;
            }
        }
        else
        {
            Console.WriteLine("Ungültige Operation!");
            return;
        }

        Console.WriteLine($"Ergebnis: {ergebnis}");
       
    }
    

}
