string[] String3CharArray(string[] mas) // Cutting of extra Strings
{
    int size = 0;
    for (int i = 0; i < mas.Length; i++)
        if (mas[i].Length <= 3) size++;
    if (size == mas.Length) return mas;
    else if (size != 0)
    {
        string[] new_mas = new string[size];
        for (int i = 0; i < mas.Length; i++)
            if (mas[i].Length <= 3)
            {
                new_mas[new_mas.Length - size] = mas[i];
                size--;
            }
    return new_mas;
    }
    else return new[] { "There are NO elements less or equal 3 Characters in Your Array" };
}
void ShowArray(string[] mas) // Just Showing the Lineary String Array
{
    for (int i = 0; i < mas.Length; i++)
    {
        if (i != mas.Length - 1) Console.Write("\"" + mas[i] + "\",");
        else Console.Write("\"" + mas[i] + "\"");
    }
    Console.WriteLine();
}
string[] GenStringArray(int number) // Creating the Lineary String Array
{
    string[] mas = new string[number];
    for (int i = 0; i < number; i++)
    {
        bool flag = false;
        while (!flag)
        {
            Console.Write($"Please, input {i + 1} String (non-empty!) Element of Array = ");
            mas[i] = Console.ReadLine();
            if (mas[i].Length != 0) flag = true;
        }
    }
    return mas;
}
Console.Clear();
Console.WriteLine("Program shows in the string Array only 3-chars elements");
Console.Write("Please, set amount of Elements You want to input N = ");
string[] s_array = GenStringArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(s_array);
Console.WriteLine($"Shorted Array with up to 3 chars Strings (Array size is {s_array.Length})");
ShowArray(String3CharArray(s_array));