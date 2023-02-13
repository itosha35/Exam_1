void String3CharArray(string[] mas) // Cutting of extra characters in Strings
{
    for (int i = 0; i < mas.Length; i++)
        if (mas[i].Length > 3)
            mas[i] = mas[i].Substring(0, 3);
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
Console.WriteLine("Program Shortcuts the string Array within 3 symbols each element");
Console.Write("Please, set amount of Elements You want to input N = ");
string[] s_array = GenStringArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(s_array);
Console.WriteLine($"Shorted to 3 chars String Array (size is {s_array.Length})");
String3CharArray(s_array);
ShowArray(s_array);