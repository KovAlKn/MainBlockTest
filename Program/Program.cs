//=============Methods===========

string[] InitArray(int n)
{
    string[] array = new string[n];
    for(int i=0; i<array.Length; i++)
    {
        Console.Write($"{i+1} элемент массива: ");
        array[i]=Console.ReadLine()??"0";
    }
    return array;
}

void PrintArray(string[] array)
{
    Console.WriteLine($"[{String.Join(", ",array)}]");
}

string[] NewArray(string[] array, int len)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if(array[i].Length<=len)
        {
            count++;
        }
    }
    string[] newArray = new string[count];
    int j=0;
    for(int i = 0; i<array.Length;i++)
    {
        if(array[i].Length<=len)
        {
            newArray[j]=array[i];
            j++;
        }

    }
    return newArray;
}

//=======Program===========
Console.Clear();
Console.WriteLine("Введите длинну массива");
int n = int.Parse(Console.ReadLine()??"0");
string[] array = InitArray(n);
Console.WriteLine("Исходный массив");
PrintArray(array);
string[] newArray = NewArray(array,3);
Console.WriteLine("Сформированный массив");
PrintArray(newArray);

