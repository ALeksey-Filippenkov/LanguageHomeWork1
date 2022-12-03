// // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// // a = 5; b = 7 -> max = 7
// // a = 2 b = 10 -> max = 10
// // a = -9 b = -3 -> max = -3

// System.Console.WriteLine("Программа, которая сравнивает два числа и выдаёт какое число большее, а какое меньшее.");
// Console.WriteLine("Введите два первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите два второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if (number1 >= number2)
//     System.Console.WriteLine($"max = {number1}");
// else
//     System.Console.WriteLine($"max = {number2}");


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// System.Console.WriteLine("Программа, которая сравнивает три числа и выдаёт максимальное из этих чисел.");
// Console.WriteLine("Введите первое число");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number1 > number2 && number1 > number3)
//     System.Console.WriteLine($"Число {number1} больше чисел {number2} и {number3}");
// else if (number2 > number1 && number2 > number3)
//     System.Console.WriteLine($"Число {number2} больше чисел {number1} и {number3}");
// else 
//     System.Console.WriteLine($"Число {number3} больше чисел {number1} и {number2}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет
// System.Console.WriteLine("Программа для проверки числа на четность.");
// Console.WriteLine("Введите любое число.");
// int number1 = Convert.ToInt32(Console.ReadLine());
// if (number1%2 ==0)
//     System.Console.WriteLine($"Да. Число {number1} является четным (делится на два без остатка)");
// else
//     System.Console.WriteLine($"Нет. Число {number1} является не четным (не делится на два без остатка)");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("Программа для которая показывает все четные числа от 1 до введеного Вами числа.");
System.Console.WriteLine("Введите любое число");
int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
System.Console.WriteLine();
/*// если запятая не нужна
while (count < n)
{
    count = count +2;
    System.Console.Write($"{count} "); // 1 способ выведения
    System.Console.WriteLine($"{count} "); // 2 способ выведения
}
*/
// если запятая нужна
while (count < n)
{
    if (count == n - 2)
        System.Console.Write($"{count}");
    else if (count % 2 == 0)
        System.Console.Write($"{count},");
    count++;
}