string[] array1 = new string[] { "Russia", "Denmark", "UK", "31213123", "321", "1" };
string[] array2 = new string[array1.Length];

void FilterAndCreateNewMassve(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FilterAndCreateNewMassve(array1, array2);
PrintArray(array2);
