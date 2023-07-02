// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

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



// string number = Console.ReadLine()!;
// int summa = 0;
// for (int i = 0; i < number.Length; i++)
//     summa = summa + Convert.ToInt32(number[i].ToString());
// Console.WriteLine(summa);