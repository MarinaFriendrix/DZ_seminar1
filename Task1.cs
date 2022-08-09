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

// Console.Write("Введите число 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());


// if(num1>num2 && num2>num3)
// {
//     Console.WriteLine(num1);
// }
// else
// {
//     if(num1<num2 && num2>num3)
//     {
//        Console.WriteLine(num2); 
//     }
//     else
//     {
//       Console.WriteLine(num3);  
//     }
// }





// // задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// Console.Write("Введите число: ");
// double num1 = Convert.ToInt32(Console.ReadLine());

// if(num1 % 2 ==0)
// {
//   Console.WriteLine("ДА");

// }
// else
// {
//   Console.WriteLine("НЕТ");
// }






// // задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());



// for (int i=1; i<=num1; i++)
// {
//   if (i % 2 ==0)
//   {
//     Console.WriteLine(i+ "");
//   }
// }



// // Задача 5. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Console.Write("Введите число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// for (int i= -num1; i <=num1; i++)
// {
//   Console.WriteLine(i+ "");
// }





// Задача 7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (99 < num1 && num1 < 1000)
{
  Console.WriteLine(num1 % 10);
}
else
{
  Console.WriteLine("Некорректное значение");
}

