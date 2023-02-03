// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Не используйте строки

int Promt(string message) // Пользователь вводит произвольное число
{
    System.Console.Write($"{message} -> ");
    return int.Parse(Console.ReadLine());
}

int Mirror(int num) // Зеркальное отражение введенного числа.
{
    int tail1 = num % 10;
    int res = tail1;

    while (num > 10)
    {
        tail1 = num % 10;
        int temp = num / 10;
        int tail2 = temp % 10;
        res = res * 10 + tail2;
        num = num / 10;
    }
    return res;
}

bool Check(int num1, int num2) // Проверка равнства 2 чисел.
{
    if (num1 == num2)
    {
        System.Console.WriteLine($"Число является палиндромом");
        return true;
    }
    else
    {
        System.Console.WriteLine($"Число не является палиндромом");
        return false;
    }

}

int Symbols(int quan) // Подсчет количества символов в числе.
{
    int count = 0;
    quan = quan * 10;
    while (quan > 1)
    {
        quan = quan / 10;
        count++;
    }
    return count;
}

int Cut(int nums, int raz) // Разрезает число на половину.
{
    while( raz > 0)
    {
        nums = nums / 10;
        raz--;
    }
    return nums;
}

int number1 = Promt("Введите число");
int number2 = Mirror(number1);
int count = Symbols(number1) / 2;
number1 = Cut(number1, count);
number2 = Cut(number2, count);

bool check = Check(number1, number2);



