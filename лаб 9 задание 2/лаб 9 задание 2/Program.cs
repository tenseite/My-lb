using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = "А роза упала на лапу Азора. Шалаш стоит. Дед пришел. Он - мадам.";
        List<string> palindromes = FindPalindromes(text);

        Console.WriteLine("Слова-палиндромы в тексте:");
        foreach (string word in palindromes)
        {
            Console.WriteLine(word);
        }
    }

    static List<string> FindPalindromes(string text)
    {
        List<string> palindromes = new List<string>();

        // Разбиваем текст на слова, игнорируя знаки препинания
        string[] words = Regex.Split(text.ToLower(), @"\W+");

        foreach (string word in words)
        {
            if (word.Length > 1 && IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }

        return palindromes;
    }

    static bool IsPalindrome(string word)
    {
        int left = 0;
        int right = word.Length - 1;

        while (left < right)
        {
            if (word[left] != word[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}