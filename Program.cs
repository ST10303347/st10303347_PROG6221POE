using System;
using System.Runtime.ConstrainedExecution;

namespace st10303347_PROG6221POE
{
    internal class Program
    {

        static void Main(string[] args)
        {
        //Declarations   
            Boolean screenON = true;
            String[] emptyarr = { };
            double[] emptyarr2 = { };
            Recipes testOB = new Recipes(" ",emptyarr,emptyarr2,emptyarr,emptyarr);
            double scale = 1;
            double newScale = 1;
           
            


            //Starts Here
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Recipe.net8!!!!!!!!");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //Boolean to keep screen on, Application will always return to the begining of a while loop after breaking out of a if statement or switch case
            while (screenON) {
                Console.Clear();
                Console.ResetColor();
                
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("1.Create a new recipe\n2.View Recipe\n3.Scale recipe\n4.Reset Quantities\n5.Delete Recipe\n6.Exit Aplication");
                int menuchoice = InputMethods.numbervalidation("choose an option from 1-6",1, 6);
            //Above is a method to validate user input so application does not crash  
                switch (menuchoice)
                {
                    case 1:
                        if (testOB.RecipeName == " ") {
   //Aplication takes user input and stores it in arrays if it can be more than 1 but the name is stored in a string                        
                            Console.WriteLine("What is your recipe name");
                            string name = Console.ReadLine();
                            Console.WriteLine("How many ingredients will you be entering?");
                            int noOfIngredients = InputMethods.numbervalidation("enter ingredients between 1-100",1, 100);
                            String[] ingredientsArr = new String[noOfIngredients];
                            double[] QuantitiesArr = new double[noOfIngredients];
                            String[] ingMeasurementArr = new String[noOfIngredients];
                            Console.Clear();
//Clear method keeps screen neat
                            for (int i = 0; i < noOfIngredients; i++)
                            {

                                int n = 1 + i;
                                Console.Write("Ingredient " + n + "\nName: ");
                                String ingName = Console.ReadLine();


                                String ingMeasurement = InputMethods.measurementValidation();
 //Quantity is verified using Double.min and max methods in Input methods class                             
                                
                                
                                double quantity = InputMethods.QuantityValid("Please enter the quantity of your ingredients");
                                ingredientsArr[i] = ingName;
                                ingMeasurementArr[i] = ingMeasurement;
                                QuantitiesArr[i] = quantity;
                                Console.Clear();

                            }
//the number of steps becomes the array size and prompts you to fill the array
                            Console.WriteLine("How many Steps will the recipe have?");
                            int noOfSteps = InputMethods.numbervalidation("Please enter the number of steps your recipe has!!",1, 100);
                            String[] stepsArr = new string[noOfSteps];
                            for (int i = 0; i < noOfSteps; i++)
                            {
                                int n = 1 + i;
                                Console.WriteLine("Step " + n + ": ");
                                String step = Console.ReadLine();
                                stepsArr[i] = step;


                            }
                            testOB = new Recipes(name, ingredientsArr, QuantitiesArr, ingMeasurementArr, stepsArr);
                            
                            ListWorker.recipeList.Add(testOB);

                            Console.WriteLine("Recipe Created"); }

                        else {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have created a recipe already"); }
                       
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();

                        break;


                    case 2:
                        Console.Clear();
                        Recipes.measurementConversion(testOB);
                        if (testOB.RecipeName != " ")
                        {
                            
                            Console.WriteLine(testOB.ToString());
                        }
//Changed error messages to red colour                       
                        else
                        {Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (testOB.RecipeName != " ")
                        {
                            
                            newScale = 1;
                            Recipes.Scale(scale, testOB, newScale);
                            scale = newScale;
                            Console.WriteLine(testOB.ToString());
                            Console.WriteLine("Welcome to scaling!");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("1.Half");
                            Console.ForegroundColor= ConsoleColor.Green;
                            Console.WriteLine("2. Double");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("3.Triple");
                            Console.ForegroundColor = ConsoleColor.White;
                            int scaling= InputMethods.numbervalidation("Please choose a scaling option from 1-3",1, 3);
                            switch (scaling) { 
  //The colour of the menu option chosen is the colour the sclaled recipe will print                          
                            case 1:
                                    Console.ResetColor();
                                    Console.Clear();
                                    Console.WriteLine(testOB.ToString()); Console.WriteLine("*******New Recipe*******"); Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    newScale = 0.5;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;
                                    
                                    break;
                                case 2:
                                    Console.ResetColor();
                                    Console.Clear();
                                    Console.WriteLine(testOB.ToString()); Console.WriteLine("*******New Recipe*******"); Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    newScale = 2;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;
                                   


                                    break;
                                case 3:
                                    Console.ResetColor();
                                    Console.Clear();
                                    Console.WriteLine(testOB.ToString()); Console.WriteLine("*******New Recipe*******"); Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    newScale = 3;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;
                                   


                                    break;


                            }
                            Recipes.measurementConversion(testOB);
                            Recipes.measurementConversion(testOB);

                            Console.WriteLine(testOB.ToString());

                        }
                        else
                        {Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        
                        
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.Clear();
                        if (testOB.RecipeName != " ")
                        {

                            newScale = 1;
                            Recipes.Scale(scale, testOB, newScale);
                            scale = newScale;

                            Console.WriteLine("Quantities Reset");
                           
                            
                            Console.ReadKey(); 
                        
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;

                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                       

                        if (testOB.RecipeName != " ")
                        {
                            Console.WriteLine("Press 1 to confirm Delete or 2 to cancel");
                             int clearOrNot = InputMethods.numbervalidation("Press 1 to confirm delete or 2 to cancel", 1, 2);
                           if(clearOrNot == 1)
                            {

                                testOB.RecipeName = " ";
                                Console.WriteLine("Recipe Cleared!!!");
                            }

                           
                        }
                        else 
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine("Have an amazing day ;)");
                        System.Environment.Exit(0);
                        
                        break;




                }
            
        }




        }
    }
}
