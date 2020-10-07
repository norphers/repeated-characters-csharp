using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static char[] name = { 'j', 'o', 'h', 'n', 'n','4','o'};
        static string surname = "doe";

        static List<char> nameCharList = new List<char>();
        static List<char> surnameCharList = new List<char>();
        static List<char> fullNameCharList = new List<char>();

        static Dictionary<char, int> dictionary = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            Console.WriteLine("Stage 1: ");
            stage1();

            Console.WriteLine("\nStage 2: ");
            stage2();

            Console.WriteLine("\nStage 3: ");
            stage3();

            Console.WriteLine("\nStage 4: ");
            stage4();

        }

        static void stage1()
        {
            loopThroughArray(name);
        }

        static void stage2()
        {
            arrayToList(name);
            printList(nameCharList);
            Console.WriteLine();
            distinguishCharacter(nameCharList);
        }

        static void stage3()
        {
            dictionaryGenerator(nameCharList);
            printDictionary(dictionary);
        }

        static void stage4()
        {
            stringToList(surname);
            fullNameCharListGen(nameCharList, surnameCharList);
            printList(fullNameCharList);
        }



        static void loopThroughArray(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        public static void distinguishCharacter(List<char> list)
        {
            foreach (char one in list)
            {
                if (isVowel(one))
                {
                    Console.WriteLine("vowel");
                }
                else if (Char.IsDigit(one))
                {
                    Console.WriteLine("names of persons don't have numbers");
                }
                else
                {
                    Console.WriteLine("consonant");
                }
            }
        }

        public static Boolean isVowel(char character)
        {
            if (character == 'a' || character == 'e' || character == 'i' || character == 'o' || character == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void arrayToList(char[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                nameCharList.Add(array[i]);
            }
        }

        public static void stringToList(string one)
        {
            for (int i = 0; i < one.Length; i++)
            {
                surnameCharList.Add(one[i]);
            }
        }

        public static void fullNameCharListGen(List<char> list1, List<char> list2)
        {
            foreach (char one in list1)
            {
                fullNameCharList.Add(one);
            }
            fullNameCharList.Add(' ');
            foreach (char one in list2)
            {
                fullNameCharList.Add(one);
            }
        }

        public static void dictionaryGenerator(List<char> list)
        {
            foreach (char one in list)
            {
                if (dictionary.ContainsKey(one))
                {
                    dictionary[one] += 1;
                }
                else
                {
                    dictionary.Add(one, 1);
                }
            }

        }

        static void printList(List<char> list)
        {
            Console.Write('[');
            for (int i = 0; i < list.Count; i++)
            {
                if (i < list.Count - 1)
                {
                    Console.Write("'" + list[i] + "', ");
                }
                else
                {
                    Console.Write("'" + list[i] + "',");
                }

            }
            Console.Write(']');
        }

        static void printDictionary(Dictionary<char, int> dictionary)
        {
            foreach (KeyValuePair<char, int> kvp in dictionary)
            {
                Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }
            
        }
    }
}
