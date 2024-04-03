﻿using System;
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

        public static int numberValidation(int min, int max) { 
        int finalChoice = 0;
        bool correctInput = false;
        string userInput;
            int intUserInput;



            while (!correctInput) {

                Console.Write("Enter a number between " + min + " and " + max + "\n");
                 userInput = Console.ReadLine();
              
                    try
                    {

                        intUserInput = int.Parse(userInput);

                        if (intUserInput >= min && intUserInput <= max)
                        {
                            finalChoice = intUserInput;
                            correctInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Please enter a number between" + min + " and " + max);
                        }


                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter a number between" + min + " and " + max);

                }





            }







            return finalChoice;
        }
    }
}