// Задача 23: Напишите программу, которая принимает на вход
// число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void CubesOfNumbers(int num) // int num = number
{
    for (int i = 1; i <= num; i++)
    {
        int cube = i * i * i;
        Console.Write($"{cube}  ");
    }
    Console.WriteLine();
}

Console.Write("Input natural number: ");
int number = Convert.ToInt32(Console.ReadLine());
while (number < 1)
{
    Console.WriteLine("Your input is uncorrect, please, input naturat number: ");
    number = Convert.ToInt32(Console.ReadLine());
}
CubesOfNumbers(number);
