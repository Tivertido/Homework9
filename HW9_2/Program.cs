// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(M, N);

        Console.WriteLine("Сумма натуральных элементов от {0} до {1} равна {2}", M, N, sum);
    
    static int CalculateSum(int m, int n)
    {
        if (m > n)
        {
            // Если M > N, возвращаем 0, так как сумма в этом случае равна 0
            return 0;
        }
        else if (m == n)
        {
            // Если M = N, возвращаем M, так как это единственное натуральное число в промежутке
            return m;
        }
        else
        {
            // Рекурсивно вызываем функцию для промежутка от M+1 до N и суммируем M с результатом
            return m + CalculateSum(m + 1, n);
        }
    }