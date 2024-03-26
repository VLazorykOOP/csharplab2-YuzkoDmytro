/*static void task1()
{
    Console.WriteLine("Task1");

       Console.WriteLine("Введіть розмірність масиву:");
        int n = int.Parse(Console.ReadLine());

        // Розв'язок з використанням одновимірного масиву
        int[] array1D = new int[n];
        int sum1D = 0;
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            array1D[i] = int.Parse(Console.ReadLine());
            sum1D += array1D[i];
        }
        Console.WriteLine("Сума елементів у одновимірному масиві: " + sum1D);
        Console.WriteLine("Сума є двозначним числом: " + (sum1D >= 10 && sum1D <= 99));

        // Розв'язок з використанням двовимірного масиву
        int[,] array2D = new int[n, 1];
        int sum2D = 0;
        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            array2D[i, 0] = int.Parse(Console.ReadLine());
            sum2D += array2D[i, 0];
        }
        Console.WriteLine("Сума елементів у двовимірному масиві: " + sum2D);
        Console.WriteLine("Сума є двозначним числом: " + (sum2D >= 10 && sum2D <= 99));
}

static void task2()
{
    Console.WriteLine("Task2");
    Console.Write("Введіть розмірність масиву: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід розмірності масиву.");
            return;
        }

        int[] array = new int[n];
        int count = 0;

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Некоректний ввід елементу масиву.");
                return;
            }

            if (i > 0 && array[i] > array[i - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Кількість елементів, значення яких більше попереднього елемента: {count}");
}

static void task3()
{
        Console.WriteLine("Task3");
        Console.Write("Введіть розмірність масиву (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід розмірності масиву.");
            return;
        }

        int[,] array = new int[n, n];

        Console.WriteLine("Введіть елементи масиву:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out array[i, j]))
                {
                    Console.WriteLine("Некоректний ввід елементу масиву.");
                    return;
                }
            }
        }

        double sum = 0;
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = n - i; j < n; j++)
            {
                if (array[i, j] != 0)
                {
                    sum += array[i, j];
                    count++;
                }
            }
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"Середнє арифметичне ненульових елементів над побічною діагоналлю: {average}");
        }
        else
        {
            Console.WriteLine("Немає ненульових елементів над побічною діагоналлю.");
        }
}*/

static void task4()
{
        Console.WriteLine("Task4");
        Console.Write("Введіть кількість рядків (n): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
        {
            Console.WriteLine("Некоректний ввід кількості рядків.");
            return;
        }

        int[][] jaggedArray = new int[n][];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у {i + 1}-му рядку: ");
            if (!int.TryParse(Console.ReadLine(), out int m) || m <= 0)
            {
                Console.WriteLine("Некоректний ввід кількості елементів у рядку.");
                return;
            }

            jaggedArray[i] = new int[m];
            Console.WriteLine($"Введіть елементи {i + 1}-го рядку:");
            for (int j = 0; j < m; j++)
            {
                if (!int.TryParse(Console.ReadLine(), out jaggedArray[i][j]))
                {
                    Console.WriteLine("Некоректний ввід елементу масиву.");
                    return;
                }
            }
        }

        int[] sums = CalculateNegativeSums(jaggedArray);
        
        Console.WriteLine("Суми від'ємних елементів для кожного стовпця:");
        for (int i = 0; i < sums.Length; i++)
        {
            Console.WriteLine($"Стовпець {i + 1}: {sums[i]}");
        }
    }

    static int[] CalculateNegativeSums(int[][] jaggedArray)
    {
        int[] sums = new int[jaggedArray[0].Length];
        for (int j = 0; j < jaggedArray[0].Length; j++)
        {
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (jaggedArray[i][j] < 0)
                {
                    sums[j] += jaggedArray[i][j];
                }
            }
        }
        return sums;
}

//task1();
//task2();
//task3();
task4();
