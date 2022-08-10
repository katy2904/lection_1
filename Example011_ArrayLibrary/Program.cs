void FillArray(int[] collection) // функция создания массива
{
    int length = collection.Length; //определяем длину массива (кол-во элементов);
    int index = 0;
    while (index < length) // цикл заполнения массива псевдослучайными числами
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count) // цикл вывода массива на консоль
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOff(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создать новый массив, в котором будет 10 элементов
// по умолчанию он будет заполнен нулями!
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOff(array, 10);
Console.WriteLine(pos);