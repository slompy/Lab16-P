
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

Console.Write("Сколько студентов в группе? ");
int studentsCount = int.Parse(Console.ReadLine()!);
int sum = 0;
int[] grades = new int[studentsCount];

for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Оценка студента {i + 1}: ");
    grades[i] = int.Parse(Console.ReadLine()!);
    sum += grades[i];
    Console.WriteLine(sum);
}

foreach (int grade in grades)
{

    Console.WriteLine($"Оценка: {grade}");
    Console.WriteLine($"Cредний балл: {sum / 4}");
}

int[] points = { 4, 7, 12, 2, 9, 5, 20 };


for (int i = 0; i < points.Length; i++)
{
    if (points[i] < 10)
    {
        points[i] = points[i] + 1;
    }
    else
    {
        continue;
    }


}



foreach (int point in points)
{

    Console.WriteLine(point);
}

