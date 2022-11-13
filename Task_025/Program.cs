// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();
Console.WriteLine("Введите число: ");
int number_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int number_B = Convert.ToInt32(Console.ReadLine());
int number_degree = 1;
for (int i = 0; i < number_B; i++)
{
    number_degree = number_degree * number_A;
}
Console.WriteLine($"Число:{number_A} в степени:{number_B}  равно:{number_degree}");
Console.ReadLine();