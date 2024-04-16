using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample recipe creation
            Ingredient[] ingredients = {
                new Ingredient("Sugar", 1, "tablespoon"),
                new Ingredient("Flour", 2, "cups"),
                new Ingredient("Eggs", 3, "units")
            };

            Step[] steps = {
                new Step("Preheat oven to 350°F."),
                new Step("Mix sugar and flour in a bowl."),
                new Step("Add eggs and mix well."),
                new Step("Pour mixture into a greased baking pan."),
                new Step("Bake for 30 minutes or until golden brown.")
            };

            Recipe myRecipe = new Recipe("Simple Cake", ingredients, steps);

            // Display the recipe
            myRecipe.DisplayRecipe();

            // Scale the recipe
            Console.WriteLine("\nScaling the recipe by a factor of 2...");
            myRecipe.ScaleRecipe(2);
            myRecipe.DisplayRecipe();

            // Reset ingredient quantities
            Console.WriteLine("\nResetting ingredient quantities...");
            myRecipe.ResetQuantities();
            myRecipe.DisplayRecipe();
            Console.ReadLine();
        }

       
    }  
}

