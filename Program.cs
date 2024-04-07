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
            Recipes testOB = new Recipes(null,null,null,null,null);
            double scale = 1;
            double newScale = 1;



            //Starts Here
            Console.WriteLine("Welcome to Recipe.net8");


        //Boolean to keep screen on, Application will always return to the begining of a while loop after breaking out of a if statement or switch case
            while (screenON) {
                Console.Clear();
                Console.WriteLine("1. Create a new recipe\n2.View Recipe\n3.Scale recipe\n4.Reset Quantities\n5.Clear Data\n6.Exit Aplication");
                int menuchoice = InputMethods.numbervalidation("choose an option from 1-6",1, 6);
            //Above is a method to validate user input so application does not crash  
                switch (menuchoice)
                {
                    case 1:
                        if (testOB.RecipeName == null) {
                            Console.WriteLine("What is your recipe name");
                            string name = Console.ReadLine();
                            Console.WriteLine("How many ingredients will you be entering?");
                            int noOfIngredients = InputMethods.numbervalidation("enter ingredients between 1-100",1, 100);
                            String[] ingredientsArr = new String[noOfIngredients];
                            double[] QuantitiesArr = new double[noOfIngredients];
                            String[] ingMeasurementArr = new String[noOfIngredients];
                            Console.Clear();

                            for (int i = 0; i < noOfIngredients; i++)
                            {

                                int n = 1 + i;
                                Console.Write("Ingredient " + n + "\nName: ");
                                String ingName = Console.ReadLine();
                                Console.Write("Measurement: ");
                                String ingMeasurement = Console.ReadLine();
                                int quantity = InputMethods.numbervalidation("Please enter the quantity of your ingredients",1, 10000);
                                ingredientsArr[i] = ingName;
                                ingMeasurementArr[i] = ingMeasurement;
                                QuantitiesArr[i] = quantity;
                                Console.Clear();

                            }

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

                        else { Console.WriteLine("You have created a recipe already"); }
                       
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();

                        break;


                    case 2:
                        Console.Clear();
                        if (testOB.RecipeName != null)
                        {

                            Console.WriteLine(testOB.ToString());
                        }
                       
                        else
                        {
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        if (testOB.RecipeName != null)
                        {
                           Console.WriteLine("Welcome to scaling!\n1.Half \n2.Double\n3.Triple");
                            int scaling= InputMethods.numbervalidation("Please choose a scaling option from 1-3",1, 3);
                            switch (scaling) { 
                            
                            case 1:
                                    newScale = 0.5;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;
                                    Console.WriteLine("Scale Done");
                            break;
                                case 2:
                                    newScale = 2;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;

                                    Console.WriteLine("Scale Done");
                                    break;
                                case 3:
                                    newScale = 3;
                                    Recipes.Scale(scale, testOB, newScale);
                                    scale = newScale;

                                    Console.WriteLine("Scale Done!");
                                    break;


                            }    

                        }
                        else
                        {
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();

                        break;

                    case 4:
                        Console.Clear();
                        if (testOB.RecipeName != null)
                        {
                            newScale = 1;
                            Recipes.Scale(scale, testOB, newScale);
                            scale = newScale;

                            Console.WriteLine("Quantities Reset");

                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey(); 
                        
                        }
                        else
                        {
                            Console.WriteLine("You have not Created a recipe yet");
                        }
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        testOB.RecipeName = null;
                        Console.WriteLine("Recipe Cleared");    
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
