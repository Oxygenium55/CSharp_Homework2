int GetNumber (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int Array(int a, int b)
{
    int result = 0;
    if(b < 3)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }
        result = (a / c) % 10;
    }
    return result;
}

int number = GetNumber("Введите число: ");
string str = number.ToString();
int count = str.Length;
Console.Write(Array(number, count));