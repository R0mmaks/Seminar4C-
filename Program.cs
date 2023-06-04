// Задача 25: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A 
// в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите основание степени");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите показатель степени");
// int b=Convert.ToInt32(Console.ReadLine());

// int count=1;
// int c=1;
// while (count<=b)
// {
//     c=c*a;
//     count++;
// }
// Console.WriteLine($"Число {a} возведенное в степень {b} равно {c}");


// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a=0;
// int del=1;
// while (num>0)
// {
//     del=num%10;
//     a=a+del;
//     num=num/10;
// }
// Console.Write($"Сумма цифр в этом числе равна {a}"); 


// Задача 29: Напишите программу, которая задаёт 
// массив из 8 элементов и выводит их на экран.
int[]CreateArray()
{
int []arr=new int [8];
int count=0;
while (count < arr.Length)
{
    arr [count]=new Random().Next(0,100);
    Console.Write($" {arr[count]} ");
    count++;
}
return arr;
}
CreateArray();