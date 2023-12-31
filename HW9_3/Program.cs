﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);

        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            // Если m = 0, возвращаем n + 1, так как A(0, n) = n + 1
            return n + 1;
        }
        else if (n == 0)
        {
            // Если n = 0, вызываем рекурсивный вызов функции с аргументами (m-1, 1)
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            // Вызываем рекурсивный вызов функции с аргументами (m-1, A(m, n-1))
            int previousResult = AckermannFunction(m, n - 1);
            return AckermannFunction(m - 1, previousResult);
        }
    }