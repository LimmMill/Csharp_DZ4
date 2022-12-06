// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.  ( 3, 5 -> 243 (3⁵)   2, 4 -> 16)

Console.WriteLine("Введите число A: ");
Console.WriteLine("Введите число B: ");
int A = Convert.ToInt32(Console.ReadLine()); //Возводимое в степень число
int B = Convert.ToInt32(Console.ReadLine()); // Cтепень возведения
int result = 1;
	for(int i=0; i<B; i++)
	{
        result = result * A;
    }
    Console.WriteLine($"число {A} в степени {B} = {result}");

	
