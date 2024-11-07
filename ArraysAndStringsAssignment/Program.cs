using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ArraysAndStringsAssignment
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            // C# Assignments on Arrays & Strings
            //--------------------------------------------------------------------------------------------------------------
            // Array Manipulations
            // Assignment 1: Write C# programs on Matrix addition, Matrix Multiplication and Matrix Transpose.
            /*int[,] matrix1 = { { 18, 19, 17 }, { 7, 8, 9 }, { 11, 12, 13 } };
            int[,] matrix2 = { { 4, 5, 6 }, { 1, 2, 3 }, { 16, 14, 15 } };
            Console.WriteLine("\nMatrix 1:");
            PrintMatrix(matrix1);
            Console.WriteLine("\nMatrix 2:");
            PrintMatrix(matrix2);

            AddMatrices(matrix1, matrix2);
            MultiplyMatrices(matrix1, matrix2);
            TransposeMatrix(matrix1);

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 2. Write C# programs to sort an array using bubble sort and insertion sort.
            /*int[] array = { 73, 44, 27, 69, 7, 3, 14 };

            Console.Write("Original Array: ");
            PrintArray(array);

            BubbleSort(array);
            InsertionSort(array);

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 3: Write C# programs to search an array using linear search and binary
            /*int[] array = { 73, 44, 27, 69, 7, 3, 14 };
            int searchElement = 69;

            Console.Write("Array: ");
            PrintArray(array);

            int result1 = LinearSearch(array, searchElement);
            if (result1 != -1)
            {
                Console.WriteLine($"Element {searchElement} found at index {result1} (Linear Search).");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the array (Linear Search).");
            }

            Array.Sort(array);
            Console.Write("\nSorted Array: ");
            PrintArray(array);

            int result2 = BinarySearch(array, searchElement);
            if (result2 != -1)
            {
                Console.WriteLine($"Element {searchElement} found at index {result2} (Binary Search).");
            }
            else
            {
                Console.WriteLine($"Element {searchElement} not found in the array (Binary Search).");
            }

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 4: Array Calculations: write C# programs for finding median, mode value,
            //               highest, second highest and duplicate elements in an array.
            /*int[] array1 = { 73, 44, 27, 69, 7, 3, 14, 35 };
            int[] array2 = { 3, 8, 7, 8, 6, 7, 4, 4, 7, 1, 7 };

            // Printing Highest and Second Highest Element in an array
            Console.Write("Array 1 Elements: ");
            PrintArray(array1);
            int highest = FindHighest(array1);
            int secondHighest = FindSecondHighest(array1);

            Console.WriteLine($"\nHighest Element: {highest}");
            Console.WriteLine($"Second Highest Element: {secondHighest}");

            // Printing Median of an array 
            Array.Sort(array1);
            Console.Write("\nSorted Array 1 Elements: ");
            PrintArray(array1);

            double median = FindMedian(array1);
            Console.WriteLine($"\nMedian: {median}");

            // Printing Mode of an array
            Console.Write("\nArray 2 Elements: ");
            PrintArray(array2);

            int mode = FindMode(array2);
            Console.WriteLine($"\nMode: {mode}");

            // Printing Duplicate elements in an array
            Console.Write("\nDuplicate Elements:");
            FindDuplicates(array2);

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // String Manipulations
            // Assignment 5: Write a C# programs to count vowels, consonants and special characters.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;
            int specialCharCount = 0;

            foreach (char ch in input)
            {
                if (IsVowel(ch))
                {
                    vowelCount++;
                }
                else if (IsConsonant(ch))
                {
                    consonantCount++;
                }
                else if (!Char.IsWhiteSpace(ch))
                {
                    specialCharCount++;
                }
            }
            Console.WriteLine($"Vowels: {vowelCount}");
            Console.WriteLine($"Consonants: {consonantCount}");
            Console.WriteLine($"Special Characters: {specialCharCount}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 6: Write a C# program to reverse a string.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string reversed = ReverseString(input);
            Console.Write($"The reversed string: {reversed}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 7: Write a C# program to find substring occurrence within a main string.
            /*Console.Write("Enter a string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter a substring: ");
            string subString = Console.ReadLine();

            int subStringOccurerence = FindSubstringOccurrences(mainString, subString);
            Console.WriteLine($"The substring '{subString}' occurs {subStringOccurerence} times");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 8: Write a C# program to convert string to uppercase, lowercase, and title case.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string upperCase = input.ToUpper();
            Console.WriteLine($"\nUppercase: {upperCase}");

            string lowerCase = input.ToLower();
            Console.WriteLine($"\nLowercase: {lowerCase}");

            string titleCase = ToTitleCase(input);
            Console.WriteLine($"\nTitle Case: {titleCase}");

            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 9: Write a C# program to remove whitespace from a string.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string noWhitespace = input.Replace(" ", "");

            Console.WriteLine($"String without whitespace: {noWhitespace}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 10: Write a C# program to replace all occurrences of a substring.
            /*Console.Write("Enter a string: ");
            string mainString = Console.ReadLine();

            Console.Write("Enter a substring to be replaced: ");
            string oldSubString = Console.ReadLine();

            Console.Write("Enter a substring to be added: ");
            string newSubString = Console.ReadLine();

            string newString = mainString.Replace(oldSubString, newSubString);
            Console.WriteLine($"New String: {newString}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 11: Write a C# program to find the longest word in a sentence.
            /*Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            string longestWord = FindLongestWord(sentence);
            Console.WriteLine($"The longest word is: {longestWord}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 12: Write a C# program to count words in a sentence.
            /*Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();

            int wordCount = CountWords(sentence);
            Console.WriteLine($"The no of words in sentence: {wordCount}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 13. Write a C# program to remove duplicate characters from a string.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string newString = RemoveDuplicates(input);
            Console.Write($"The new string after removing duplicate characters: {newString}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 14: Write a C# program to check if two strings are anagrams.
            /*Console.Write("Enter the first string: ");
            string firstString = Console.ReadLine();

            Console.Write("Enter the second string: ");
            string secondString = Console.ReadLine();

            bool areAnagrams = AreAnagrams(firstString, secondString);
            if (areAnagrams)
            {
                Console.WriteLine("The strings are anagrams.");
            }
            else
            {
                Console.WriteLine("The strings are not anagrams.");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 15: Write a C# program to find the frequency of each character in a string.
            /*Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char ch in input)
            {
                if (frequency.ContainsKey(ch))
                {
                    frequency[ch]++;
                }
                else
                {
                    frequency[ch] = 1;
                }
            }
            // Display the frequency of each character
            Console.WriteLine("Number frequencies:");
            foreach (KeyValuePair<char, int> entry in frequency)
            {
                Console.WriteLine($"Character {entry.Key}: {entry.Value} times");
            }
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 16: Write a C# program to find the first non-repeating character in a string.
            /* Console.Write("Enter a string: ");
             string input = Console.ReadLine();

             Dictionary<char, int> frequency = new Dictionary<char, int>();

             foreach (char ch in input)
             {
                 if (frequency.ContainsKey(ch))
                 {
                     frequency[ch]++;
                 }
                 else
                 {
                     frequency[ch] = 1;
                 }
             }

             foreach (char ch in input)
             {
                 if (frequency[ch] == 1)
                 {
                     Console.WriteLine($"The first non-repeating character is: {ch}");
                     break;
                 }
             }
             Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 17.Write a C# program to reverse words in a sentence.
            /*Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            string reversedSentence = ReverseWords(input);

            Console.WriteLine($"Reversed sentence: {reversedSentence}");
            Console.ReadLine();*/

            //--------------------------------------------------------------------------------------------------------------
            // Assignment 18: Write a C# program to check if a string contains only digits.
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            bool containsOnlyDigits = ContainsOnlyDigits(input);

            if (containsOnlyDigits)
            {
                Console.WriteLine("The string contains only digits.");
            }
            else
            {
                Console.WriteLine("The string does not contain only digits.");
            }
            Console.ReadLine();

            //--------------------------------------------------------------------------------------------------------------
        }
    }
}
