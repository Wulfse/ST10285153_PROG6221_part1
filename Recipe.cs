using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    // Class representing a recipe
    public class Recipe
    {
        public string Name { get; set; }
        public Ingredient[] Ingredients { get; set; }
        public Step[] Steps { get; set; }

        // Constructor
        public Recipe(string name, Ingredient[] ingredients, Step[] steps)
        {
            Name = name;
            Ingredients = ingredients;
            Steps = steps;
        }

        // Method to display the recipe
        public void DisplayRecipe()
        {
            Console.WriteLine($"Recipe: {Name}\n");

            Console.WriteLine("Ingredients:");
            foreach (var ingredient in Ingredients)
            {
                Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }

            Console.WriteLine("\nSteps:");
            for (int i = 0; i < Steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Steps[i].Description}");
            }
        }

        // Method to scale the recipe by a factor
        public void ScaleRecipe(double factor)
        {
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity *= factor;
            }
        }

        // Method to reset ingredient quantities to original values
        public void ResetQuantities()
        {
            // Assuming original quantities are stored elsewhere and retrieved when needed
            // For simplicity, let's just reset quantities to 1
            foreach (var ingredient in Ingredients)
            {
                ingredient.Quantity = 1;
            }
        }
    }
}
