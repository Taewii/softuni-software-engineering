﻿using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class p02_WormIpsum
{
    public static void Main()  // I didnt write this one
    {
        var regex = new Regex(@"[A-Z]{1}[\w\W]+?\.{1,}");
        var currentSentence = Console.ReadLine();
        while (currentSentence != "Worm Ipsum")
        {
            var matched = regex.Matches(currentSentence);
            if (matched.Count > 1)
            {
                currentSentence = Console.ReadLine();
                continue;
            }
            var newSentence = ProcessAndValidate(currentSentence);
            Console.WriteLine($"{newSentence}.");

            currentSentence = Console.ReadLine();
        }
    }

    private static string ProcessAndValidate(string currentSentence)
    {
        var returnedSentence = string.Empty;
        var words = currentSentence.TrimEnd('.').Split(' ');
        var isFirst = true;
        foreach (var word in words)
        {
            var currentWord = FindMostOccurendLetter(word);
            if (isFirst)
            {
                returnedSentence += currentWord;
                isFirst = false;
                continue;
            }
            returnedSentence += $" {currentWord}";
        }
        return returnedSentence;
    }

    static string FindMostOccurendLetter(string word)
    {
        var symbols = new Dictionary<char, int>();
        for (int index = 0; index < word.Length; index++)
        {
            var currentSymbol = word[index];
            if (!symbols.ContainsKey(currentSymbol))
            {
                symbols[currentSymbol] = 0;
            }
            symbols[currentSymbol]++;
        }
        var returnedWord = symbols.OrderByDescending(x => x.Value).First().Key;
        var value = symbols.OrderByDescending(x => x.Value).First().Value;
        if (value >= 2)
        {
            var newWord = String.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == '\'')
                {
                    newWord += '\'';
                }
                else if (word[i] == ',')
                {
                    newWord += ',';
                }
                else
                {
                    newWord += returnedWord;
                }
            }
            return newWord;
        }
        else
        {
            return word;
        }

    }
}