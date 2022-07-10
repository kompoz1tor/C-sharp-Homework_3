/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
Console.WriteLine("Введите пятизначное число, для проверки является оно полиндромом или нет: ");
string number = Console.ReadLine();
int firstNumber = 0;
int lastNumber = number.Length - 1;
Polindrom(number, firstNumber, lastNumber);

void Polindrom (string N, int First, int Last)
{
    if (N[First] == N[Last] && N[First + 1] == N[Last - 1]) 
    {
        Console.WriteLine ($"Число {N} является полиндромом");
    }
    else Console.WriteLine ($"Число {N} не является полиндромом");
}

