// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

double Promt(string? message)
{
    System.Console.Write(message + " - > ");
    string? inputValue = Console.ReadLine();
    double result = Convert.ToDouble(inputValue);
    return result;
}

double Cub(double num)
{
    double count = 0;
    double count1 = 1;
    double result = 0;
    while (count < num)
    {
        result = Math.Pow(count1, 3);
        System.Console.Write(result + " ");
        count1++;
        count++;
    }
    return result;
}

double number = Promt("Введите число");
double res = Cub(number);