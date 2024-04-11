using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10303347_PROG6221POE
{
    internal class InputMethods
    {
        public InputMethods()
        {
        }

       


        public static int numbervalidation(String msg,int min, int max) {

            int finalChoice = 0;
            bool correctInput = false;
            string userInput;
            int intUserInput;

            while (!correctInput)
            {
                userInput = Console.ReadLine();

                try
                {
                    intUserInput = int.Parse(userInput);

                    if (intUserInput >= min && intUserInput <= max)
                    {
                        Console.Clear();
                        finalChoice = intUserInput;
                        correctInput = true;
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(msg);
                    }


                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(msg);

                }
            }

            return finalChoice;
        }
        
        }
    }
