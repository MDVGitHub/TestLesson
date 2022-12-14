/*Задача: Написать программу, которая из имеющегося массива строк формирует новый 
массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный 
массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При 
решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/
void Array1(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива строк:  ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
void Array2(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]}");
            if (i < array[i].Length - 1)
            {
                Console.Write(", ");
            }
        }
    }
    Console.WriteLine("]");
}

Console.Write("Введите количество элементов массива: ");
int Count = Convert.ToInt32(Console.ReadLine());
string[] arraynew = new string[Count];
Array1(arraynew);
Console.WriteLine();
Console.WriteLine("Введенный массив:");
PrintArray(arraynew);
Console.WriteLine("Полученный массив:");
Array2(arraynew);