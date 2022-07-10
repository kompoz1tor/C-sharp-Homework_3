/*
Дан массив длиной 10 элементов. Заполнить его последовательно числами от 1 до 10.
*/

int size = 10;
int[] array = new int[size];

fillArray(array);
printArray(array);



//заполнение
void fillArray(int[] Array)
{
    for (int i = 0; i < size; i ++)
    {
        Array[i] = i + 1; 
    } 
}

//вывод
void printArray(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write (Array[i] + "  ");
    }
}

