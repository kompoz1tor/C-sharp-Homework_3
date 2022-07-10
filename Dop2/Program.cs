/*
Задача 2. Дано трёхзначное число N. Определить кратна ли трём сумма всех его цифр
*/

Console.WriteLine("Введите трехзначное число: ");
string number = (Console.ReadLine());
int sum = 0;

Multiple(number, sum);

void Multiple(string array, int result)
{
    if (number.Length == 3) 
    {
        int number1  = Convert.ToInt32(number[0]);
        int number2  = Convert.ToInt32(number[1]);
        int number3  = Convert.ToInt32(number[2]);
        sum = sum + number1 + number2 + number3;
        if (sum % 3 == 0)
        {
            Console.WriteLine($"Cумма всех цифр числа {number} кратна трем");
        }
        else Console.WriteLine($"Cумма всех цифр числа {number} НЕ кратна трем");
    }

    else Console.WriteLine("Неверный формат, введите трехзначное число: ");
}

