
// using System.ComponentModel.DataAnnotations;
// using System.Runtime.InteropServices;

// Console.Write("Сколько студентов в группе? ");
// int studentsCount = int.Parse(Console.ReadLine()!);
// int sum = 0;
// int[] grades = new int[studentsCount];

// for (int i = 0; i < grades.Length; i++)
// {
//     Console.Write($"Оценка студента {i + 1}: ");
//     grades[i] = int.Parse(Console.ReadLine()!);
//     sum += grades[i];
//     Console.WriteLine(sum);
// }

// foreach (int grade in grades)
// {

//     Console.WriteLine($"Оценка: {grade}");
//     Console.WriteLine($"Cредний балл: {sum / 4}");
// }

// int[] points = { 4, 7, 12, 2, 9, 5, 20 };


// for (int i = 0; i < points.Length; i++)
// {
//     if (points[i] < 10)
//     {
//         points[i] = points[i] + 1;
//     }
//     else
//     {
//         continue;
//     }


// }



// foreach (int point in points)
// {

//     Console.WriteLine(point);
// }

// int[] grades = { 4, 5, 3, 5, 4, 2 };

// for (int i = 0; i < grades.Length - 1; i++)
// {
//     for (int j = 0; j < grades.Length - 1 - i; j++)
//     {
//         if (grades[j] < grades[j + 1])
//         {
//             int temp = grades[j];
//             grades[j] = grades[j + 1];
//             grades[j + 1] = temp;

//         }
//     }
// }

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// System.Console.WriteLine();

// int[] GenerateScheduleSlots(int lessonsCount)
// {
//     int[] slots = new int[lessonsCount];

//     for (int i = 0; i < lessonsCount; i++)
//     {
//         if (i % 2 != 0)
//         {
//             slots[i] = i + 1;
//         }

//     }

//     return slots;
// }

// int[] slots = GenerateScheduleSlots(6);

// foreach (int slot in slots)
// {
//     Console.WriteLine(slot);
// }



// int[] grades = { 4, 5, 3, 5, 4, 2 };
// Array.Sort(grades);

// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
// }

// // Задача А
// System.Console.Write("Введите целое число: ");
// int n = int.Parse(Console.ReadLine()!);

// int[] squares = new int[n];

// for (int i = 0; i < n; i++)
// {
//     int number = i + 1;
//     squares[i] = number * number;
// }

// foreach (int square in squares)
// {
//     Console.Write(square + " ");
// }

// // Задача Б
// System.Console.Write("Циферки: ");
// int[] numbers = { 5, -3, 12, -8, 0, -1, 7 };

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] < 0)
//     {
//         numbers[i] = 0;
//     }
// }

// foreach (int num in numbers)
// {
//     Console.Write(num + " ");
// }

// Вариант 4: Числа Фибоначчи

Console.WriteLine("Вариант 4: Числа Фибоначчи");
Console.WriteLine();

Console.Write("Введите ваше число: ");
int n = int.Parse(Console.ReadLine()!);
int[] results = GenerateFibonacci(n);
foreach (int result in results)
{
    Console.Write(result + " ");
}


static int[] GenerateFibonacci(int n)
{

    int[] fib = new int[n];

    fib[0] = 1;

    if (n > 1)
    {
        fib[1] = 1;
    }

    for (int i = 2; i < n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }

    return fib;
}

// Вариант 8: Обрезка значений

Console.WriteLine();
Console.WriteLine("Вариант 8: Обрезка значений");
Console.WriteLine();

double[] temperatures = { 12.5, -4.2, 0.0, -15.8, 23.1, -0.5, 8.0 };


for (int i = 0; i < temperatures.Length; i++)
{
    if (temperatures[i] < 0)
    {
        temperatures[i] = 0;
    }
}

foreach (double temp in temperatures)
{
    Console.Write(temp + " ");
}

Console.WriteLine();