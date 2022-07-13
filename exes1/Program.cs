// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int m, int n)
{
    if (n < m)
    {
        return;
    }

    PrintNatural(m, n - 2);
    System.Console.Write($"{n} ");
}

int m = Prompt("Введите число М => ");
int n = Prompt("Введите число N => ");
if (n % 2 == 1) n--;

PrintNatural(m, n);