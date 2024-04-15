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
        {
            
//neat to string for displaying my recipe
            StringBuilder finalString = new StringBuilder(); 
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
            Recipes.measurementConversion(myRecipe);
            for (int i = 0; i < myRecipe.Quantities.Length; i++)
            {
                myRecipe.Quantities[i] /= currentScale;
                myRecipe.Quantities[i] *= newScale;
            }

            Recipes.measurementConversion(myRecipe);

        }
        public static void measurementConversion(Recipes anObj)
        {
          
    //This class changes the unit of measurement to correct unit
            for (int i = 0; i < anObj.Ingredients.Length; i++)
            {
                if (anObj.Measurements[i].Contains("ml") || anObj.Measurements[i].Contains("mililitre") && anObj.Quantities[i] >= 1000)
                {
                    anObj.Measurements[i] = "litres";
                    anObj.Quantities[i] = anObj.Quantities[i] / 1000;

                }
                if (anObj.Measurements[i].Contains("l") || anObj.Measurements[i].Contains("litre") && anObj.Quantities[i] < 1)
                {
                    anObj.Measurements[i] = "mililitre";
                    anObj.Quantities[i] = anObj.Quantities[i] * 1000;

                }
                if (anObj.Measurements[i].Contains("tbsp") || anObj.Measurements[i].Contains("tablespoon") && anObj.Quantities[i] > 8)
                {
                    anObj.Measurements[i] = "cup";
                    anObj.Quantities[i] = anObj.Quantities[i] / 16;

                }
                if (anObj.Measurements[i].Contains("cup")  && anObj.Quantities[i] < 1)
                {
                    anObj.Measurements[i] = "tablespoon";
                    anObj.Quantities[i] = anObj.Quantities[i] * 16;

                }
                if (anObj.Measurements[i].Contains("g") || anObj.Measurements[i].Contains("gram") && anObj.Quantities[i] > 1000)
                {
                    anObj.Measurements[i] = "kilogram";
                    anObj.Quantities[i] = anObj.Quantities[i] / 1000;

                }
                if (anObj.Measurements[i].Contains("kilogram") && anObj.Quantities[i] < 1)
                {
                    anObj.Measurements[i] = "gram";
                    anObj.Quantities[i] = anObj.Quantities[i] * 1000;

                }


            }

        }
    }
}
