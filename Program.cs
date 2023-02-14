using static System.Console;
Clear();
WriteLine("Введите массив строк через запятую: ");
string[] newArray = ReadLine()!.Split(new string[] { ", ", "," }, StringSplitOptions.RemoveEmptyEntries);
int l = 3;
PrintArray(GetArray(newArray, FilterArray(newArray, l), l));

int FilterArray(string[] inArray, int length)
{
    int count = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= length)
        {
            count++;
        }
    }
    return count;
}

string[] GetArray(string[] inArray, int count, int length)
{
    if (count == 0)
    {
        string[] outArray = new string[count + 1];
        return outArray;
    }
    else
    {
        string[] outArray = new string[count];
        int j = 0;
        for (int i = 0; i < inArray.Length; i++)
        {
            if (inArray[i].Length <= length && j < count)
            {
                outArray[j] = inArray[i];
                j++;
            }
        }
        return outArray;
    }
}

void PrintArray(string[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]}, ");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}