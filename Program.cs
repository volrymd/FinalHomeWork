
void InputArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите элемент массива: ");
        string input = Convert.ToString(Console.ReadLine()!);
        array [i] = input;
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine($"Исходный массив: [{string.Join(", ", array)}]");
}

void ChangeArray (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       string find = array[i];
       if (find.Length <=3) count ++;
 
    }
    string[] array2 = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
       string find = array[i];
       if (find.Length <=3) 
       {array2 [j] = array[i];
       j++;}
 
    }   
       Console.WriteLine($"Конечный массив: [{string.Join(", ", array2)}]"); 
}

Console.Clear();
Console.Write("Введите длину массива: ");
int n = int.Parse(Console.ReadLine()!);
string[] array = new string[n];
InputArray (array);
PrintArray (array);
ChangeArray (array);
