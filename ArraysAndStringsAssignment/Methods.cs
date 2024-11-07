using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndStringsAssignment
{
    internal partial class Program
    {
        // C# Assignments on Arrays & Strings
        //--------------------------------------------------------------------------------------------------------------
        // Array Manipulations
        // Assignment 1: Write C# programs on Matrix addition, Matrix Multiplication and Matrix Transpose.

        // Method to add two Matrices
        static void AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int[,] result = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            Console.WriteLine("\nMatrix Addition Result:");
            PrintMatrix(result);
        }

        // Method to Multiply two Matrices
        static void MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int rows2 = matrix2.GetLength(0);
            int cols2 = matrix2.GetLength(1);
            if (cols1 != rows2)
            {
                Console.WriteLine("Matrix multiplication is not possible with these dimensions.");
                return;
            }
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            Console.WriteLine("\nMatrix Multiplication Result:");
            PrintMatrix(result);
        }

        // Method Find Transpose of a Matrix
        static void TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] transpose = new int[cols, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transpose[j, i] = matrix[i, j];
                }
            }
            Console.WriteLine("\nMatrix1 Transpose Result:");
            PrintMatrix(transpose);
        }

        // Method to print Matrix
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 2. Write C# programs to sort an array using bubble sort and insertion sort.
        // Method to implement bubblesort
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Swap arr[j] and arr[j+1]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.Write($"\nThe Sorted Array(Bubble Sort): ");
            PrintArray(arr);
        }

        // Method to implement insertion sort
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
            Console.Write($"\nThe Sorted Array(Insertion Sort): ");
            PrintArray(arr);
        }

        // Method to print an Array Elements
        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 3: Write C# programs to search an array using linear search and binary
        // Mathod to implement Linear Search
        static int LinearSearch(int[] arr, int searchElement)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == searchElement)
                {
                    return i; // Return the index of the element
                }
            }
            return -1; // Element not found
        }

        // Mathod to implement Binary Search
        static int BinarySearch(int[] arr, int searchElement)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (arr[mid] == searchElement)                // Check if the target is at the middle
                {
                    return mid;                               // return index of the element
                }
                if (arr[mid] < searchElement)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }
            return -1; // Element not found
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 4: Array Calculations: write C# programs for finding median, mode value,
        //               highest, second highest and duplicate elements in an array.
        // Method to Find Median of Array Elements
        static double FindMedian(int[] arr)
        {
            int n = arr.Length;
            if (n % 2 == 0)
            {
                // Average of two middle elements for even length
                return (arr[n / 2 - 1] + arr[n / 2]) / 2.0;
            }
            else
            {
                // Middle element for odd length
                return arr[n / 2];
            }
        }

        // Method to Find Mode value of Array Elements
        static int FindMode(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in arr)
            {
                if (frequency.ContainsKey(num))
                {
                    frequency[num]++;
                }
                else
                {
                    frequency[num] = 1;
                }
            }

            int mode = arr[0];
            int maxCount = 0;
            foreach (var item in frequency)
            {
                if (item.Value > maxCount)
                {
                    maxCount = item.Value;
                    mode = item.Key;
                }
            }
            return mode;
        }

        // Method to Find Highest Element in an Array
        static int FindHighest(int[] arr)
        {
            int highest = arr[0];
            foreach (int num in arr)
            {
                if (num > highest)
                {
                    highest = num;
                }
            }
            return highest;
        }

        // Method to Find Highest Element in an Array
        static int FindSecondHighest(int[] arr)
        {
            int highest = int.MinValue;
            int secondHighest = int.MinValue;
            foreach (int num in arr)
            {
                if (num > highest)
                {
                    secondHighest = highest;
                    highest = num;
                }
                else if (num > secondHighest)
                {
                    secondHighest = num;
                }
            }
            return secondHighest;
        }

        // Method to Find Duplicate Elements in an Array
        static void FindDuplicates(int[] arr)
        {
            HashSet<int> seen = new HashSet<int>();
            HashSet<int> duplicates = new HashSet<int>();

            foreach (int num in arr)
            {
                if (seen.Contains(num))
                {
                    duplicates.Add(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            foreach (int dup in duplicates)
            {
                Console.Write(dup + " ");
            }
        }

        //--------------------------------------------------------------------------------------------------------------
        // String Manipulations
        // Assignment 5: Write a C# programs to count vowels, consonants and special characters.
        // Method to check the character is vowel or not
        static bool IsVowel(char ch)
        {
            char lowerChar = Char.ToLower(ch);
            return lowerChar == 'a' || lowerChar == 'e' || lowerChar == 'i' || lowerChar == 'o' || lowerChar == 'u';
        }

        // Method to check the character is Consonent or not
        static bool IsConsonant(char ch)
        {
            return Char.IsLetter(ch);
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 6: Write a C# program to reverse a string.
        static string ReverseString(string str)         //Method to Reverse a String
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            return reversed;
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 7: Write a C# program to find substring occurrence within a main string.
        // Method to find occurence of a substring
        static int FindSubstringOccurrences(string mainString, string substring)
        {
            int count = 0;
            int startIndex = 0;

            while ((startIndex = mainString.IndexOf(substring, startIndex)) != -1)
            {
                count++;
                startIndex += substring.Length; // Move to the next position past the current substring
            }

            return count;
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 8: Write a C# program to convert string to uppercase, lowercase, and title case.
        static string ToTitleCase(string str)
        {
            string[] words = str.ToLower().Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                // Capitalize the first letter and combine with the rest of the word
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            }
            return string.Join(" ", words);
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 9: Write a C# program to remove whitespace from a string.
        // Implemented in Program.cs

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 10: Write a C# program to replace all occurrences of a substring.
        // Implemented in Program.cs

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 11: Write a C# program to find the longest word in a sentence.
        // Method to find Longest Word.
        static string FindLongestWord(string sentence)
        {
            string[] words = sentence.Split(' ');
            string longestWord = null;

            foreach (string word in words)
            {
                if (longestWord == null || word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            return longestWord;
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 12: Write a C# program to count words in a sentence.
        // Method to Count Words in a sentence
        static int CountWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            return words.Length;
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 13: Write a C# program to remove duplicate characters from a string.
        // Method to remove duplicate characters
        static string RemoveDuplicates(string str)
        {
            HashSet<char> chars = new HashSet<char>();
            string newString = null;
            foreach (char ch in str)
            {
                if (chars.Add(ch))
                {
                    newString += ch;
                }
            }
            return newString;
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 14: Write a C# program to check if two strings are anagrams.
        // Method to check if two strings are anagrams.
        static bool AreAnagrams(string str1, string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int[] charCount = new int[26]; 

            foreach (char c in str1)
            {
                charCount[c - 'a']++;
            }
            foreach (char c in str2)
            {
                charCount[c - 'a']--; 
            }

            foreach (int count in charCount)
            {
                if (count != 0)
                {
                    return false;
                }
            }
            return true; 
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 15: Write a C# program to find the frequency of each character in a string.
        // Implemented in Program.cs

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 16: Write a C# program to find the first non-repeating character in a string.
        // Implemented in Program.cs

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 17: Write a C# program to reverse words in a sentence.
        // Method to reverse words in a sentence
        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            Array.Reverse(words);

            return string.Join(" ", words);
        }

        //--------------------------------------------------------------------------------------------------------------
        // Assignment 18: Write a C# program to check if a string contains only digits.
        // Method to check if a string contains only digits
        static bool ContainsOnlyDigits(string str)
        {
            foreach (char c in str)
            {

                if (!char.IsDigit(c))           // If the character is not a digit, return false
                {
                    return false;
                }
            }
            return true;                // Return true if all characters are digits
        }

        //--------------------------------------------------------------------------------------------------------------
    }
}
