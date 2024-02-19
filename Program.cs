// See https://aka.ms/new-console-template for more information

// Это строка выводит текст 
// Console.WriteLine("Hello, World!");

// Напишите программу, которая на вход принимает
// число и выдает его квадрат (число умноженное
// на само себя).

// Например:
// 4 -> 16
// -3 -> 9
// -7 -> 49

//Console.WriteLine("Введите число");
//int num = Convert.ToInt32(Console.ReadLine());

//int result = num * num;
//Console.WriteLine(result);


// Задача №1. Напишите программу, которая на
// вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

// Console.WriteLine("Введите число");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2=Convert.ToInt32(Console.ReadLine());

// if(num1 == num2*num2)
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }

// Задача №3. Напишите программу, которая
// будет выдавать название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.WriteLine("Введите число");
int num=Convert.ToInt32(Console.ReadLine());

if(num == 1)
{
Console.WriteLine("Понедельник");
}
else if(num == 2)
{
Console.WriteLine("Вторник");
}
else if(num == 3)
{
Console.WriteLine("Среда");
}
else if(num == 4)
{
Console.WriteLine("Четверг");
}
else if(num == 5)
{
Console.WriteLine("Пятница");
}
else if(num == 6)
{
Console.WriteLine("Суббота");
}
else if(num == 7)
{
Console.WriteLine("Воскресенье");
}
else
{
Console.WriteLine("Такого дня нет");
}

