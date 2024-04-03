using System.Runtime.ConstrainedExecution;

namespace st10303347_PROG6221POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InputMethods m = new InputMethods();
            Boolean screenON = true;
            Console.WriteLine("Welcome to Recipe.net8");
            while (screenON) {
                Console.WriteLine("1. Create a new recipe\n2.View Recipe\n3.Exit Application");
                int menuchoice = InputMethods.numberValidation(1, 3);
               
                switch (menuchoice)
                {
                    case 1:
                        Console.WriteLine("you picked 1");
                        break;
                    case 2:
                        Console.WriteLine("you picked 2");
                        break;
                    case 3:
                        Console.WriteLine("BYEEEE");
                        System.Environment.Exit(0); 
                        break;




                }
            
        }




        }
    }
}
