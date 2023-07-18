﻿//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input power: ");
int power = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i = 0; i < power; i++)
{
    result *= number;
}
Console.WriteLine($"Number {number} to the power of {power} is {result}");

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Input some number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine($"Sum of all digits of a number is {sum}");

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
void fillArray(int[] arr)
{   //Console.WriteLine("Input the size of array: "); для рандомного ввода
    //int size = Convert.ToInt32(Console.ReadLine());
    int size = arr.Length;
    Console.WriteLine("Input the lower bound of array: ");
    int start = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input the upper bound of array: ");
    int finish = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(start, finish);
        Console.Write($"{arr[i]} ");
    }
}
fillArray(array);