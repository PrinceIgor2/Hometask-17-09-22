/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
Console.Write("Введите число А: "); 
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: "); 
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число С: "); 
int numberС = Convert.ToInt32(Console.ReadLine());
int max = numberA;
if(numberA > numberB)
{
  Console.WriteLine($"Максимальное число - {numberA}, минимальное число - {numberB}");
}
else
{
    Console.WriteLine($"Максимальное число - {numberB}, минимальное число - {numberA}");    
}

