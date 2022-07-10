/*
Дано трёхзначное число N. Определить, есть ли среди него цифры 4 или 7.
*/




Random rand = new Random();
int[] number = new int [3];

fillNumber(number);
printNumber (number);
Result(number);

//Заполнили массив размером в 3 числа рандомными цифрами от 4 до 7
void fillNumber (int[] Array)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = rand.Next(4,7);
    }
}

//Вывели в консоль
void printNumber (int[] Array)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write (number[i]);
    }
    Console.WriteLine();
}


//Поиск до первой 4 или 7, for и if разбил, чтобы выводилось одно сообщение а не 3
void Result(int[] Array)
{
    int temp = 0;
    for (int i = 0; i < number.Length; i++ )
    {
        if (number[i] == 4 ^ number[i] == 7) //Если элемент массива равен 4 или 7 -->
        {   
            temp = temp + 1;
            break;
        }
        else temp = 0;
        
    }
    if (temp == 1)
        {
            Console.WriteLine($"Среди цифр ЕСТЬ 4 или 7");
        }
        else Console.WriteLine($"Среди цифр НЕТ 4 или 7");
}
