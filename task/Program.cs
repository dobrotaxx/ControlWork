string[] GenerateUserArray(string message)
{
    Console.Write(message);
    int userArrayLength = Convert.ToInt32(Console.ReadLine());
    string[] userArray = new string[userArrayLength];
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"Введите значение для элемента массива с индексом {i}: ");
        userArray[i] = Console.ReadLine().ToString();
    }
    return userArray;
}

void PrintArray(string message, string[] arrayTwoPrint)
{
    Console.Write(message);
    Console.Write("[");
    for (int i = 0; i < arrayTwoPrint.Length; i++)
    {
        Console.Write(arrayTwoPrint[i]);
        if (i < arrayTwoPrint.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

string[] ChangerOfArray(string[] sourceArray)
{
    int count = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            count++;
        }
    }
    string[] NewArray = new string[count];
    int indexOfNewArray = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            NewArray[indexOfNewArray]=sourceArray[i];
            indexOfNewArray++;
        }
    }
    return NewArray;
}

string[] userArray = GenerateUserArray("Задайте длину массива: ");
PrintArray("Ваш массив: ", userArray);
string[] result = ChangerOfArray(userArray);
PrintArray("Итог работы программы: ", result);