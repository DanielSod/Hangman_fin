using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hangman_v3._0
{
    class theWordCL
    {


        static public void insert_word()
        {
            



            Console.Clear();
            Console.WriteLine("Welcome game master!\n");
            Console.Write("It's time to choose your word: ");
            string Word_str = Console.ReadLine();

            


            char[] Word_arr = new char[Word_str.Length];


            for (int i = 0; i < Word_str.Length; i++)
            {
                Word_arr[i] = Word_str[i];

            }

            for (int g = 0; g < Word_str.Length; g++)
            {
                Console.Write("I en sträng ser det ut såhär: {0}\n", Word_arr[g]);
            }

            
            Console.Write("How many fails do you allow: ");
            int fail = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"\nThe word chosen is: {WORD} and has {word_length} characters \n and you allowed {fail} for the player.");
            Console.WriteLine("\n \nPress any key to continue");
            Console.ReadKey();


        }

   

      

    }
}
