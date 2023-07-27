string[] Array;
Array = GetArray();

Console.WriteLine($"Элементы массива введенные пользователем = [{String.Join(", ", Array)}]");


string[] GetArray()
{
    Console.Write("Введите элементы массива через пробел: ");
    string Array = Console.ReadLine()!;
    string[] stringsArray = Array.Split(' ');

    return stringsArray;
}

void PrintArray(string[] array)
{
    int size = array.Length;
    int length = 0;
    int newArraySize = 0;
    for (int i = 0; i < size; i++)
    {
        length = array[i].Length;
        if (length <= 3)
        {
            newArraySize++;
        }

    }
    if (newArraySize == 0)
    {
        Console.Write("[]");
        return;
    }
    string[] newArray = new string[newArraySize];
    int j = 0;
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        length = array[i].Length;

        if (length <= 3)
        {
            newArray[j] = array[i];
            Console.Write(newArray[j] + " ");
            j++;
        }

    }
    Console.Write("]");
}

PrintArray(Array);
