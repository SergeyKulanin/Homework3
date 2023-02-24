// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Console.WriteLine("Введите пятизначное число: ");
string number = int.Parse(Console.ReadLine());
int lenght = number.Length;

if (lenght == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - "Это палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - "Это не палиндром");
    }
}
else
{
    Console.WriteLine($"{number} - не является пятизначным");
}