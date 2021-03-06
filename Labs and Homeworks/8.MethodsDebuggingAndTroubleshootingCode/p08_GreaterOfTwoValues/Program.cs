﻿using System;


class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        if (type == "char")
        {
            var first = char.Parse(Console.ReadLine());
            var second = char.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else if (type == "int")
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(first, second));
        }
        else
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();
            Console.WriteLine(GetMax(first, second));
        }
    }

    static int GetMax(int first, int second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static string GetMax(string first, string second)
    {
        if (first.CompareTo(second) >= 0)
        {
            return first;
        }
        else
        {
            return second;
        }
    }

    static char GetMax(char first, char second)
    {
        if (first >= second)
        {
            return first;
        }
        else
        {
            return second;
        }
    }
}

