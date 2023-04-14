/*
    Задача 41: Пользователь вводит с клавиатуры M чисел.
    Посчитайте, сколько чисел больше 0 ввёл пользователь.
    0, 7, 8, -2, -2 -> 2
    1, -7, 567, 89, 223-> 3
*/

using System;

class Program {
  static void Main() {
    int m, count = 0;

    Console.WriteLine("Введите количество чисел:");
    m = int.Parse(Console.ReadLine());

    for (int i = 1; i <= m; i++) {
      Console.WriteLine("Введите число " + i + ":");
      int num = int.Parse(Console.ReadLine());
      if (num > 0) {
        count++;
      }
    }

    Console.WriteLine("Количество чисел больше 0: " + count);
  }
}