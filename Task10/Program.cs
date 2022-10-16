Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int first2Digits = number / 10;
int secondDigit = first2Digits % 10;

if(number > 99 && number < 1000)
{
    Console.WriteLine($"Вторая цифра числа {number} - {secondDigit}");
}
else
{
    Console.WriteLine("Введенное число не является трехзначным");
}
