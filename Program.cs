/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

using System;
namespace Exam_Work;
class Work_string
{
    public static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введите количество элементов массива");
        int size = int.Parse(Console.ReadLine()!);
        string[] set_strings = new string [size];
        Console.WriteLine("Введите элементы строчного массива");
        for (int i= 0; i< set_strings.Length; i++)
        {
            set_strings[i] = Console.ReadLine()!;
        }
        Console.WriteLine($"Начальный массив: [\"{string.Join("\" ,\"", set_strings)}\"]");
       
        string[] set_new = new string[size];
        for (int k= 0; k< set_strings.Length; k++)
        {
            string a = set_strings[k]; 
            if (a.Length <=3)
            set_new[k] = set_strings[k];
        }
        set_new = set_new.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        Console.WriteLine($"Искомый массив: [\"{string.Join("\" ,\"", set_new)}\"]");
   
    }
}
