//27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt()
{
    Console.WriteLine("Введите число");
    int a= int.Parse(Console.ReadLine());
    return a;
}

int number = Prompt();

int Sum(int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum = sum + number % 10;
        number /= 10;
    }

    return sum;
}

int res = Sum(number);
Console.WriteLine(res);