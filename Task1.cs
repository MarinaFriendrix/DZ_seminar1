// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите число 1: ");
// double num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double num2 = Convert.ToInt32(Console.ReadLine());

// if (num1==num2)
// {
//     Console.WriteLine("числа равны");

// }
// else
// {
//     if(num1>num2)
//     Console.WriteLine("Число 1 больше Числа 2");
//     else
//     Console.WriteLine("Число 2 больше Числа 1");

// }



// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());


if(num1>num2 && num2>num3)
{
    Console.WriteLine(num1);
}
else
{
    if(num1<num2 && num2>num3)
    {
       Console.WriteLine(num2); 
    }
    else
    {
      Console.WriteLine(num3);  
    }
}