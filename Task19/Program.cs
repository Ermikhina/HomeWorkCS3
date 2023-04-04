// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

string Palind(int num)
{
    int dig1 = num / 10000;
    int dig2 = num / 1000 % 10;
    int dig4 = num / 10 % 10;
    int dig5 = num % 10;
    string result = (dig1 == dig5 && dig2 == dig4) ? "palindrome" : "not palindrome";
    return result;
}
Console.Write("Input 5-digit number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
while (number < 10000 || number > 99999)
{
    Console.WriteLine("Your input is uncorrect, please, input 5-digit number: ");
    number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
}
string output = Palind(number);
Console.Write($"Number {number} is {output}");
