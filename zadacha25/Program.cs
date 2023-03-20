// 25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int PromptA()
{
    Console.WriteLine("Введите число A");
    int a = int.Parse(Console.ReadLine());
    return a;
}

int PromptB()
{
    Console.WriteLine("Введите число B");
    int b = int.Parse(Console.ReadLine());
    return b;
}

int numbera = PromptA();
int numberb = PromptB();

double Pow(int a ,int b)
{
    double st = 1;

    st = Math.Pow(a,b);
     return st;
}
double result = Pow(numbera,numberb);
Console.WriteLine($"{numbera} в степени {numberb} = {result}");
