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

