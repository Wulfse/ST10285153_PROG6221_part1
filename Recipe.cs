using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    /// <summary>
    /// Class representing a recipe
    /// </summary>
    ///-----------------------------------------------------------------------------------------------------------///
    public class Recipe
    {
        //getter and setter for the name of the recipe
        public string Name { get; set; }

        //getter and setter for the ingredients array
        public Ingredient[] Ingredients { get; set; }

        //getter and setter for the original quantities entered array
        public Ingredient[] OriginalQuantities { get; set; }

        //getter abd setter for the steps array
        public Step[] Steps { get; set; }
        //---------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ingredients"></param>
        /// <param name="steps"></param>
        ///-------------------------------------------------------------------------------------------------------------///
        public Recipe(string name, Ingredient[] ingredients, Step[] steps)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;

            // Store original quantities
            OriginalQuantities = new Ingredient[ingredients.Length];
            for (int i = 0; i < ingredients.Length; i++)
            {
                // Copy ingredient details to OriginalQuantities array
                OriginalQuantities[i] = new Ingredient(ingredients[i].Name, ingredients[i].Quantity, ingredients[i].Unit);
            }
        }
        //----------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to display the recipe( recipe name, ingreidents and steps)
        /// </summary>
        /// -------------------------------------------------------------------------------------------------------------///
        public void DisplayRecipe()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Recipe: {Name}\n");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
            Console.WriteLine("-------------------------------------------------");
        }
        //-----------------------------------------------------------------------------------------------------------------//
        
        /// <summary>
        ///  Method to scale the recipe by a factor
        /// </summary>
        /// <param name="factor"></param>
        /// ---------------------------------------------------------------------------------------------------------------//
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }
        //-------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        /// Method to reset ingredient quantities to original values
        /// </summary>
        /// ---------------------------------------------------------------------------------------------------------------///
        public void ResetQuantities()
        {
            // Restore original quantities
            for (int i = 0; i < Ingredients.Length; i++)
            {
                Ingredients[i].Quantity = OriginalQuantities[i].Quantity;
            }
        }
    }
}
//---------------------------------------------------------End of Class------------------------------------------------------//
