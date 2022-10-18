Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
string numStr = Convert.ToString(num);
int numDigit = numStr.Length;
if(numDigit > 2)
{
    Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
}
else
{
    Console.WriteLine("третьей цифры нет");
}
