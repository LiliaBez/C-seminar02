// Напишите программу, которая будет принимать на вход 
//два числа и выводить, является ли второе число кратным 
//первому. Если число 2 не кратно числу 1, 
//то программа выводит остаток от деления.

Console.WriteLine("Введите число A");
int FirstNumber = int.Parse(Console.ReadLine()); 
Console.WriteLine("Введите число B");
int SecondNumber = int.Parse(Console.ReadLine());

int result = SecondNumber % FirstNumber;

if (result == 0)
Console.WriteLine($"Число {SecondNumber} кратно числу {FirstNumber}"); 
else
Console.WriteLine($"Число {SecondNumber} не кратно числу {FirstNumber}, остаток {result}");
