//Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру числа.

using System; // делать не обязательно, подразумевается в современных версиях языка

int number = new Random ().Next (10, 100); 
// датчик случайных чисел от 10 до 99 включительно
Console.WriteLine(number);

int digit1 = number / 10; // digit = цифра, number = число
int digit2 = number % 10;

if (digit1 >= digit2)
    Console.WriteLine(digit1);
else 
    Console.WriteLine(digit2);