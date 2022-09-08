// Напишите программу, которая принимает на вход 
//число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()); 
int del1 = 7;
int del2 = 23;


int result1 = number % del1;
int result2 = number % del2;

if (result1 == 0)
{
    if (result2 == 0)
        Console.WriteLine($"Число {number} кратно одновременно 7 и 23");
else
Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");   
}
else
Console.WriteLine($"Число {number} не кратно одновременно 7 и 23");  
  
