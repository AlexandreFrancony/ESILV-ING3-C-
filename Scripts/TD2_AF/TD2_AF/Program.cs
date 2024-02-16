using System;
using System.Collections.Generic;

namespace TD2_AF
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            Console.WriteLine("1-1: Enter words (one per line). Enter a dot (.) to stop:");

            string word;
            while ((word = Console.ReadLine()) != ".")
            {
                words.Add(word);
            }

            Console.WriteLine("Phrase:");

            foreach (string w in words)
            {
                Console.Write(w + " ");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            

            Stack<string> wordsStack = new Stack<string>();

            Console.WriteLine("1-2: Enter words (one per line). Enter a dot (.) to stop:");

            string wordStack;
            while ((wordStack = Console.ReadLine()) != ".")
            {
                wordsStack.Push(wordStack);
            }

            Console.WriteLine("Phrase:");

            while (wordsStack.Count > 0)
            {
                Console.Write(wordsStack.Pop() + " ");
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            Queue<string> wordsQueue = new Queue<string>();

            Console.WriteLine("1-3: Enter words (one per line). Enter a dot (.) to stop:");

            string wordQueue;
            while ((wordQueue = Console.ReadLine()) != ".")
            {
                wordsQueue.Enqueue(wordQueue);
            }

            Console.WriteLine("Phrase:");

            while (wordsQueue.Count > 0)
            {
                Console.Write(wordsQueue.Dequeue() + " ");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();

            ListeChainee<int> a = new ListeChainee<int>(); 
            a.AddHead(5); 
            a.AddHead(6); 
            a.AddQueue(7); 
            a.Affiche(); 
            a.Insert(4, 1); 
            a.Affiche(); 
            ListeChainee<string> a1 = new ListeChainee<string>(); 
            a1.AddHead("5"); 
            a1.AddHead("6"); 
            a1.AddQueue("7"); 
            a1.Affiche(); 
            a1.Insert("4", 1); 
            a1.Affiche();
        }
    }
}