using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10303347_PROG6221POE
{
    internal class Recipes
    {
        public String RecipeName { get; set; }
        public String[] Ingredients { get; set; }
        public double[] Quantities { get; set; }
        public String[] Measurements { get; set; }


        public Array RecipeSteps { get; set;}

        public Recipes(string recipeName, string[] ingredients, double[] quantities, string[] measurements, Array recipeSteps)
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            Quantities = quantities;
            Measurements = measurements;
            RecipeSteps = recipeSteps;
        }

        public override string ToString()
        {       StringBuilder finalString = new StringBuilder(); 
            finalString.AppendLine("Recipe Name: " + RecipeName);
            finalString.AppendLine("\nIngredients ");
          
            for (int i = 0; i < Ingredients.Length; i++) {
                int n = i + 1;
                finalString.AppendLine(n + ". " +Quantities.GetValue(i) +" " +Measurements.GetValue(i)+ " of " + Ingredients.GetValue(i) );    
                
            
            }
            finalString.AppendLine("\nRecipe Steps: ");
            for (int i = 0; i < RecipeSteps.Length; i++) {
                int n = i + 1;
                finalString.AppendLine("Step "+ n + ": "+ RecipeSteps.GetValue(i) );

            }

            return finalString.ToString();
        }

        public static void Scale(double currentScale, Recipes myRecipe, double newScale) {

            for (int i = 0; i < myRecipe.Quantities.Length; i++)
            {
                myRecipe.Quantities[i] /= currentScale;
                myRecipe.Quantities[i] *= newScale;
            }



        }
    }
}
