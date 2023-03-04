string[] GetArray(string text)
{
    Console.Write(text);
    string str = Console.ReadLine() ?? "";
    string[] strArr = str?.Split(",") ?? Array.Empty<string>();
    return strArr;
}



void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length - 1) Console.Write (arr[i] + ", ");
        else Console.Write(arr[i]);
    }
    Console.Write("]");
}

void DelStrStartSpace(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i].TrimStart();
    }
}

string[] GetStrArrSpecificLength(string[] arr, int strLength)
{
    return arr.Where(s => s.Length <= strLength).ToArray();
}

string[] array = GetArray("Введите значения через запятую: ");
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine();

DelStrStartSpace(array);

string[] specificArray = GetStrArrSpecificLength(array, 3);
Console.WriteLine("Массив, содержащий строки длиной не более 3 символов:");
PrintArray(specificArray);
