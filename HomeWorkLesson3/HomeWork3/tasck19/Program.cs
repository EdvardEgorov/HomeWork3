﻿Console.Clear();
Console.Write("Введите 5-значное число: ");
string number = Console.ReadLine()!;
if (number[0]==number[4] || number[1]==number[3])
    Console.WriteLine("yes");
else 
    Console.WriteLine("no");

