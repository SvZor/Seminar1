﻿// Задача 1 Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

// public class Answer {
//     static void CompareNumbers(int firstNumber, int secondNumber)
//     {
//         // Введите свое решение ниже

// if (firstNumber > secondNumber)
// {
//     Console.WriteLine("первое число больше");    
// }
// else if (firstNumber < secondNumber)
// {
//     Console.WriteLine("второе число больше");
// }
// else if (firstNumber == secondNumber)
// {
//     Console.WriteLine("числа равны");
// }
//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int firstNumber, secondNumber;

//         if (args.Length >= 2) {
//             firstNumber = int.Parse(args[0]);
//             secondNumber = int.Parse(args[1]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             firstNumber = 6;
//             secondNumber = 3;
//         }

//         // Не удаляйте строки ниже
//         CompareNumbers(firstNumber, secondNumber);
//     }
// }

// Задача 2 Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа и выдаёт максимальное из этих чисел.

// public class Answer {
    
//   static int FindMax(int a, int b, int c)
//     {
//       // Введите свое решение ниже
// int max = a;

// if (b > max)
// {
//     max = b;
// }
//  if (c > max)
// {
//     max = c;
// }
//   return max; // Добавляем возврат максимального значения
     

//     }

//   // Не удаляйте и не меняйте метод Main! 
//   static public void Main(string[] args) {
//         int a, b, c;

//         if (args.Length >= 3) {
//            a = int.Parse(args[0]);
//            b = int.Parse(args[1]);
//            c = int.Parse(args[2]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//            a = 5;
//            b = 6;
//            c = 7;
//         }

//         // Не удаляйте строки ниже
//         int result = FindMax(a, b, c);
//         System.Console.WriteLine($"{result}");
//     }
// }

// Задача 4
// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 
// 1 до number (включительно), после каждого числа должен быть знак пробела.
// public class Answer {
//     static void PrintEvenNumbers(int number)
//     {
//       // Введите свое решение ниже
//     for (int i = 1; i <= number; i++)
//         {
//             if (i % 2 == 0)
//             {
//                 Console.Write(i + " ");
//             }
//         }

//     }


//   // Не удаляйте и не меняйте метод Main! 
//     static public void Main(string[] args) {
//         int number;

//         if (args.Length >= 1) {
//             number = int.Parse(args[0]);
//         } else {
//            // Здесь вы можете поменять значения для отправки кода на Выполнение
//             number = 8;
//         }

//         // Не удаляйте строки ниже
//         PrintEvenNumbers(number);
//     }
// }
// Задача 3
// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number 
// и выводит, является ли число чётным (делится ли оно на два без остатка).

class Answer {
    static void CheckIfEven(int number)
    {
      // Введите свое решение ниже
       if (number % 2 == 0) {
            Console.Write("четное");
        }
        else {
            Console.Write("нечетное");
        }
  
    }
  

  // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 3;
        }

        // Не удаляйте строки ниже
        CheckIfEven(number);
    }
}