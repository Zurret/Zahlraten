int guess;
int min = 1;
int max = 150;
Random rnd = new Random();
int number = rnd.Next(min, max + 1);
int guesses = 0;

Console.WriteLine($"Errate eine Zahl zwischen {min} und {max}");

do
{
    Console.Write("Gebe deine Zahl ein: ");
    if (!int.TryParse(Console.ReadLine(), out guess))
    {
        Console.WriteLine("Ungültige Eingabe. Bitte gib eine Zahl zwischen {0} und {1} ein!", min, max);
        continue;
    }

    guesses++;

    if (guess == number)
    {
        Console.WriteLine("RICHTIG!");
        Console.WriteLine($"Die gesuchte Zahl war {number}");
        Console.WriteLine($"Du hast {guesses} Versuche gebraucht!");
        break;
    }
    else if (guess > number)
    {
        Console.WriteLine($"Die Zahl ist kleiner als {guess}");
    }
    else if (guess < number)
    {
        Console.WriteLine($"Die Zahl ist größer als {guess}");
    }
}
while (guess != number);

Console.ReadKey();