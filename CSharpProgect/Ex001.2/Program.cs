﻿//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.


Console.Clear();
Console.WriteLine("Введите трехзначное число.");
   while(true)
    {
        string input = Console.ReadLine();
        Console.WriteLine("{0}->{1}",input, input[1]);
    }



