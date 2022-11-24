/* Задача: 
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

/*Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> [] */


string[] GetArrayFromString(string value)
{
    string[] array = value.Split(",", StringSplitOptions.RemoveEmptyEntries);
    return array;
}


bool IsValidValue(string checkingValue)
{
    return (checkingValue.Length > 0);
}

Console.Write("Задайте массив строк (через запятую): ");
string getValue = Console.ReadLine();
int checkLen = 3;
bool isValid = IsValidValue(getValue);

if (isValid)
{
    int counter = 0;
    string[] inputArray = GetArrayFromString(getValue);
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i].Length <= checkLen)
        {
            counter++;
        }
    }
    if (counter > 0)
    {
        string[] outputArray = new string[counter];
        int index = 0;
        for (int k = 0; k < inputArray.Length; k++)
        {
            if (inputArray[k].Length <= checkLen)
            {
                outputArray[index] = inputArray[k];
                index++;
            }
        }
        Console.WriteLine($"[{string.Join(", ", inputArray)}] -> [{string.Join(", ", outputArray)}].");
    }
    else
    Console.WriteLine($"[{string.Join(", ", inputArray)}] -> [].");
    
}
else
{
    Console.WriteLine("Введены некорректные данные.");
}