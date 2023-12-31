﻿/* Написать программу, которая из имеющегося массива строк формирует 
массив из строк, длина которых меньше либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма.*/

string Prompt()
{
  Console.Write($"Введите значение: ");
  string str = Console.ReadLine()!.ToString();
  return str;
}
string[] GetArray()
{
  int size = new Random().Next(3, 5);
  string[] array = new string[size];
  for (int i = 0; i < size; i++)
  {
    array[i] = Prompt();
  }
  return array;
}
void PrintArray(string[] array)
{
  Console.Write($"[{String.Join(", ", array)}]");
}

void FindElement(string[] array)
{
  var result = new string[array.Length];
  var count = 0;
  foreach (var el in array)
  {
    if (el.Length <= 3)
    {
      result[count] = el;
      count++;
    }
  }
  if (result[0] == null)
  {
    Console.Write(" -> []");
  }
  else
  {
    Console.Write($" -> [{string.Join(", ", result, 0, count)}]");
  }
}

Console.Clear();
string[] array = GetArray();
Console.WriteLine();
PrintArray(array);
FindElement(array);


