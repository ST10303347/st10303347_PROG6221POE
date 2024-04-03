using System.Runtime.ConstrainedExecution;

namespace st10303347_PROG6221POE
{
    internal class Program
    {

        static void Main(string[] args)
        {
        //Declarations   
            Boolean screenON = true;
           




        //Starts Here
            Console.WriteLine("Welcome to Recipe.net8");


        //Boolean to keep screen on, Application will always return to the begining of a while loop after breaking out of a if statement or switch case
            while (screenON) {

                Console.WriteLine("1. Create a new recipe\n2.View Recipe\n3.Scale recipe\n4.Reset Quantities\n5.Clear Data\n6.Exit Aplication");
                int menuchoice = InputMethods.numberValidation(1, 6);
            //Above is a method to validate user input so application does not crash  
                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("How many ingredients will you be entering?");
                        int noOfIngredients = InputMethods.numberValidation(1, 100);
                        String[] ingredientsArr = new String[noOfIngredients];
                        int[] QuantitiesArr = new int[noOfIngredients];
                        Console.Clear();

                        for (int i = 0; i < noOfIngredients; i++)
                        {

                            int n = 1 + i;
                            Console.Write("Ingredient "+ n +"\nName: ");
                            String ingName = Console.ReadLine();
                            Console.Write("Measurement: ");
                            String ingMeasurement = Console.ReadLine();
                            int quantity = InputMethods.CheckQuantity(1, 1000);
                            ingredientsArr[i] = ingName;
                            QuantitiesArr[i] = quantity;    
                            Console.Clear();

                        }   

                        Console.WriteLine("How many Steps will the recipe have?");    
                        int noOfSteps = InputMethods.numberValidation(1, 100);
                        String[] stepsArr = new string[noOfSteps];

                        


                        break;


                    case 2:

                         
                        break;
                    case 3:
                        Console.WriteLine("3333");
                        
                        break;

                    case 4:
                        Console.WriteLine("you picked 4");
                        break;
                    case 5:
                        Console.WriteLine("you picked 5");
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
