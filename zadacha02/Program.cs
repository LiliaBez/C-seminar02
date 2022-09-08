// Напишите программу, которая выводит случайное трёхзначное 
// число и удаляет вторую цифру этого числа.

int number = new Random ().Next (100, 1000); 
// датчик случайных чисел от 100 до 999 включительно
Console.WriteLine(number);

int digit1 = number / 100; // digit = цифра, number = число
int digit2 = number % 10;

Console.Write(digit1);
Console.Write(digit2);
