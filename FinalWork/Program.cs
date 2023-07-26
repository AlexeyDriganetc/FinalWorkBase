//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine("Введите строки: ");
string[] size = Console.ReadLine()!.Split().ToArray();
Console.WriteLine();
Console.WriteLine($"Заданный массив");
Console.WriteLine($"[{string.Join(", ", size)}]");
int i = 0;
for (i = 0; i <size.Length; i++)
{string n = size[i];
if (n.Length <= 3)
  {Console.WriteLine($"{size[i]}");};

}
Console.WriteLine($"Новый массив");
Console.WriteLine($"[{string.Join(", ", size_new)}]");


