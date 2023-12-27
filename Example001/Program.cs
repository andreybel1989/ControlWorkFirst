// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArray()
{
    Console.WriteLine("Enter the numbers of elements");
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[arrayLength];
    int index = 1;
    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine($"Input {index} element");
        array[i] = Console.ReadLine();
        index++;
    }

    return array;
}
string[] array = GetArray();
Console.Write($"First arrray: [{String.Join(", ", array)}]\n");

void FilterArray(string[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] filterArray = new string[count];
    int filterIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            filterArray[filterIndex] = array[i];
            filterIndex++;
        }
    }
    Console.Write($"New array: [{String.Join(", ", filterArray)}]\n");

}
FilterArray(array);