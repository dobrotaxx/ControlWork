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