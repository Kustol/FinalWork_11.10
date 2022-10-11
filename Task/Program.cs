
//Проверка исходного массива на 3х-значные символы и создание нового
string[] GenArray(string[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] newarray = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newarray[j] = array[i];
            j++;
        }
    }
    return newarray;
}

// Печать массива
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}


// string[] array = { "1234", "1567", "-2", "computer science"};
// string[] array = { "Russia", "Denmark", "Kazan"};
string[] array = { "hello", "2", "world", ":-)" };

Console.WriteLine("Исходный массив: ");
PrintArray(array);
Console.WriteLine();

string[] newarray = GenArray(array);
Console.WriteLine("Искомый массив символов, которые < либо = 3: ");
PrintArray(newarray);
