// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int AddNumber(int m, int n)
{
    if (n > m)
    {
        return n + AddNumber(m, n - 1);
    }
    else return n;
}
int m = Prompt("Введите число М => ");
int n = Prompt("Введите число N => ");
int sum = AddNumber(m, n);
System.Console.WriteLine($"Сумма чисел => {sum}");
