﻿/*Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
c -> ["2", ":-)"]
['1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

string[] newArrayS(string[] array)
{
    int j =0;
    for(int i=0;i<array.Length;i++)
    {
        if(array[i].Length <= 3)
        {
            j++;
        }
    }
    string[] newArraySimbols = new string[j];
    j=0;
    for(int i =0;i<array.Length;i++)
    {
        if(array[i].Length <=3)
        {
            newArraySimbols[j] = array[i];
            j++;
        }
    }
    return newArraySimbols;
}


void printArray(string[] array)
{
    for(int i=0;i<array.Length;i++)
    {
        Console.WriteLine($"{array[i]}  ");
    }
}

string[] textArray = {"Lucky", "1322", "lows", "GB", "top"};
printArray(textArray);
Console.WriteLine();
string[] newArray = newArrayS(textArray);
printArray(newArray);