using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1 - Kalkulator (+, -, *, /)");
        Console.WriteLine("2 - Konwerter temperatur (C <-> F)");
        Console.WriteLine("3 - Średnia ocen ucznia");
        Console.Write("Wybierz zadanie (1/2/3): ");
        string wybor = Console.ReadLine();

        if (wybor == "1")
        {
            Kalkulator();
        }
        else if (wybor == "2")
        {
            KonwerterTemperatur();
        }
        else if (wybor == "3")
        {
            SredniaOcen();
        }
        else
        {
            Console.WriteLine("Błąd: nieprawidłowy wybór.");
        }
    }

    static void Kalkulator()
    {
        Console.Write("Podaj pierwszą liczbę: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Podaj drugą liczbę: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Wybierz operację (+, -, *, /): ");
        string op = Console.ReadLine();

        if (op == "+")
        {
            Console.WriteLine("Wynik: " + (a + b));
        }
        else if (op == "-")
        {
            Console.WriteLine("Wynik: " + (a - b));
        }
        else if (op == "*")
        {
            Console.WriteLine("Wynik: " + (a * b));
        }
        else if (op == "/")
        {
            if (b != 0)
                Console.WriteLine("Wynik: " + (a / b));
            else
                Console.WriteLine("Błąd: nie można dzielić przez zero.");
        }
        else
        {
            Console.WriteLine("Błąd: nieznana operacja.");
        }
    }

    static void KonwerterTemperatur()
    {
        Console.Write("Wybierz kierunek (C - Celsjusz na Fahrenheit, F - Fahrenheit na Celsjusz): ");
        string kierunek = Console.ReadLine();

        Console.Write("Podaj temperaturę: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        if (kierunek == "C" || kierunek == "c")
        {
            double f = temp * 1.8 + 32;
            Console.WriteLine($"{temp}°C = {f}°F");
        }
        else if (kierunek == "F" || kierunek == "f")
        {
            double c = (temp - 32) / 1.8;
            Console.WriteLine($"{temp}°F = {c}°C");
        }
        else
        {
            Console.WriteLine("Błąd: nieznany kierunek konwersji.");
        }
    }

    static void SredniaOcen()
    {
        Console.Write("Ile ocen chcesz wprowadzić? ");
        int n = Convert.ToInt32(Console.ReadLine());

        double suma = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Podaj ocenę {i + 1}: ");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena;
        }

        double srednia = suma / n;
        Console.WriteLine($"Średnia: {srednia:F2}");

        if (srednia >= 3.0)
            Console.WriteLine("Uczeń zdał.");
        else
            Console.WriteLine("Uczeń nie zdał.");
    }
}
