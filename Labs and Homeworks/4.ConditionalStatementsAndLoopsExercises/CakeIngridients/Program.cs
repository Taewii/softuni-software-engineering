﻿using System;


class Program
{
    static void Main(string[] args)
    {
        string ingredients = Console.ReadLine();
        int counter = 0;

        while (ingredients != "Bake!")
        {
            Console.WriteLine($"Adding ingredient {ingredients}.");
            ingredients = Console.ReadLine();
            counter++;
        }

        Console.WriteLine($"Preparing cake with {counter} ingredients.");
    }
}

