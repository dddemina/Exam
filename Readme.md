# Итоговая контрольная работа по основному блоку 

## Задача 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение 

Для решения задачи составим блок-схему:

<img src="images\flowchart_exam_work.jpg" width="300" height="1000">

Решение на языке C# может выглядеть следующим образом:

```using System;
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
```
В начале программы объявляется целочисленная переменная **_size_** которая вводится с консоли после запроса _"Введите количество элементов массив":
``` 
Console.WriteLine("Введите количество элементов массива");
int size = int.Parse(Console.ReadLine()!);
```
командой 
```
string[] set_strings = new string [size];
```
объявляется массив элементов типа _**string**_ на _**size**_ элементов.
Далее в цикле FOR производится заполнение элементов массива с консоли и вывод заполненного начального  массива в консоль :
```
for (int i= 0; i< set_strings.Length; i++)
        {
            set_strings[i] = Console.ReadLine()!;
        }
        Console.WriteLine($"Начальный массив: [\"{string.Join("\" ,\"", set_strings)}\"]");
```
дале по условиям задачи объявляется новый массив строк 
```
string[] set_new = new string[size];
```
В цикле FOR производится поиск элементов массива удовлетворяющих условиям задачи (длина строки меньше или равна 3)

```
for (int k= 0; k< set_strings.Length; k++)
        {
            string a = set_strings[k]; 
            if (a.Length <=3)
            set_new[k] = set_strings[k];
        }
```
Из цикла FOR массив set_new возвращается с количеством элементов  равным size, для исключения пустых элементов массива которые образовались при несоответствии условию задачи, производится исключение их из массива и вывод искомого массива в консоль:
```

        set_new = set_new.Where(x => !string.IsNullOrEmpty(x)).ToArray();
        Console.WriteLine($"Искомый массив: [\"{string.Join("\" ,\"", set_new)}\"]");
```

