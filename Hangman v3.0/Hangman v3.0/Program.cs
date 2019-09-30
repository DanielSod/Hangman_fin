using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Hangman_v3._0
{
    class Program
    {
        static void Main(string[] args)
        {

        #region Startar och avslutar
        start:
            main_intro.runWelcome();
            string mainmenu = Console.ReadLine();

            switch (mainmenu)
            {
                case "1":
                    //theWordCL.insert_word();
                    goto startgame;

                case "2":
                    goto endgame;

                default:
                    Console.WriteLine("Wrong input, write number silly! \n and press any key to continue");
                    Console.ReadKey();
                    goto start;

            }
        #endregion

        #region setup game
        startgame:
            Console.Clear();
            Console.WriteLine("Welcome game master!\n");
            Console.Write("It's time to choose your word: ");
            string Word_str = Console.ReadLine();


            int word_length = Word_str.Length;

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

            Console.WriteLine($"\nThe word chosen is: {Word_str} and has {word_length} characters \n and you allowed {fail} fal for the player.");

            Console.WriteLine("\n \nPress any key to continue");
            Console.ReadKey();

            
            int lettersRevealed = 0;
            char guess;
            string input;
            

            StringBuilder displayToPlayer = new StringBuilder(Word_str.Length);

            for (int i = 0; i < Word_str.Length; i++)
            {
                displayToPlayer.Append('_');
            }

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();


            #endregion



            Console.Clear();
            Console.WriteLine("\n \n Nu är spelet igång");

            #region spelets gång
            while (fail > 0)
            {

                Console.Write("Guess a letter: ");

                input = Console.ReadLine();
                guess = input[0];


                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }




                if (Word_arr.Contains(guess))
                    {
                        correctGuesses.Add(guess);

                        for (int i = 0; i < word_length; i++)
                        {
                            if (Word_arr[i] == guess)
                            {
                                displayToPlayer[i] = Word_str[i];
                                lettersRevealed++;
                            }
                        }

                    }

                else
                {
                    incorrectGuesses.Add(guess);
                    Console.WriteLine("There is no '{0}' in the word! \n You now have {1} fails left", guess, fail);
                    fail--;
                }


                if (lettersRevealed == word_length)
                {
                    Console.WriteLine("You won!");
                    Console.Write("Do you wanna play again? y/n: ");
                    char restart = Convert.ToChar(Console.ReadLine());
                    if (restart == 'y')
                        goto start;
                    else
                    break;
                }

                if (fail == 0)
                {
                    Console.WriteLine("You Lose! The right word was {0}", Word_str);
                    Console.Write("Do you wanna play again? y/n: ");
                    char reset = Convert.ToChar(Console.ReadLine());
                    if (reset == 'y')
                        goto start;

                }
    //            else
    //                break;
                Console.WriteLine(displayToPlayer.ToString());
                

                
            }
        #endregion


        endgame:
            Console.WriteLine("\n \nPress any key to contine...");
            Console.ReadKey();



            




        }
    }
}
