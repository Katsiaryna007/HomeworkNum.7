// Задача 1: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.

// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return start.ToString();
//     return start + " " + PrintNumbers(start + 1, end);
// }
// Console.WriteLine($"Натуральные числа от {M} до {N} = {PrintNumbers(M, N)}");


// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.Write("Введите неотрицательное число n: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите неотрицательное число m: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int CalculateAckermanFunction(int n, int m)
// {
//     if (n == 0) return m + 1;
//     else if (n > 0 && m == 0) return CalculateAckermanFunction(n - 1, 1);
//     else return CalculateAckermanFunction(n - 1, CalculateAckermanFunction(n, m - 1));
// }
// Console.WriteLine($"Функция Аккермана равна: {CalculateAckermanFunction(n, m)}");

// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.


// int FlipArray(int[] array, int i)
// {
//    if (i == 0) return array[i];
//    if (i < array.Length && i > 0) return FlipArray(array, i - 1);
// }
// int[] array = { 1, 3, 5, 7, 10 };
// int rezult = FlipArray(array);
// Console.WriteLine($"Реверс: + rezult");


