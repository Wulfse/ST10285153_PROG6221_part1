using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_part1
{
    internal class Program
    {
        /// <summary>
        /// Main class
        /// </summary>
        /// <param name="args"></param>
        /// ------------------------------------------------------------------------------------------------------------///
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Recipe App!");

            // Create a new recipe
            Recipe myRecipe = CreateRecipe();

            // Display the recipe
            Console.WriteLine("\nYour recipe:");
            myRecipe.DisplayRecipe();

            // Options menu
            while (true)
            {
                // Display options menu
                Console.WriteLine("\nOptions:");
                Console.WriteLine("1. Scale the recipe");
                Console.WriteLine("2. Reset ingredient quantities");
                Console.WriteLine("3. Clear the recipe and start a new one");
                Console.WriteLine("4. Exit");

                //prompting user to enter choice from the options menu
                Console.Write("Enter your choice: ");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input! Please enter a valid integer choice.");
                    continue;
                }

                switch (choice)
                {
                    //option 1 is to scal the values in the recipe
                    case 1:
                        //prompting user to select what factor to scale by
                        Console.Write("Enter scale factor (0.5 for half, 2 for double, 3 for triple): ");

                        
                        double factor;

                        //eroor message if a numeric value wasnt entered
                        if (!double.TryParse(Console.ReadLine(), out factor))
                        {
                            Console.WriteLine("Invalid input! Please enter a valid numeric value for the scale factor.");
                            continue;
                        }
                        //scaling og the values
                        myRecipe.ScaleRecipe(factor);

                        // Clear the console screen 
                        Console.Clear();

                        //displaying scaled recipe
                        Console.WriteLine("\nRecipe scaled successfully!");
                        myRecipe.DisplayRecipe();
                        break;

                    case 2:
                        // Clear the console screen
                        Console.Clear();

                        //resets quantities in recipe to original values that were inputted
                        myRecipe.ResetQuantities();

                        //displays the original recipe
                        Console.WriteLine("\nIngredient quantities reset successfully!");
                        myRecipe.DisplayRecipe();
                        break;

                    case 3:
                        // Clear the console screen
                        Console.Clear();

                        //start a new recipe
                        myRecipe = CreateRecipe();
                        Console.WriteLine("\nNew recipe created successfully!");
                        myRecipe.DisplayRecipe();
                        break;

                    case 4:
                        //closes the application
                        Console.WriteLine("\nThank you for using the Recipe App!");
                        return;

                    default:
                        Console.WriteLine("\nInvalid choice! Please enter a valid option.");
                        break;
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------//

        /// <summary>
        ///  Method to create a recipe by prompting the user for input
        /// </summary>
        /// <returns></returns>
        /// --------------------------------------------------------------------------------------------------------------///
        static Recipe CreateRecipe()
        {
            Console.WriteLine("\nCreating a new recipe...");

            // Get recipe name from the user
            Console.Write("Enter recipe name: ");
            string recipeName = Console.ReadLine();

            // Get number of ingredients from the user
            int numIngredients;
            do
            {
                Console.Write("Enter the number of ingredients: ");
                if (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid positive integer for the number of ingredients.");
                }
            } while (numIngredients <= 0);

            // Gets ingredients from the user and stores them in the array
            Ingredient[] ingredients = new Ingredient[numIngredients];

            for (int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine($"Enter details for ingredient {i + 1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                double quantity;
                do
                {
                    Console.Write("Quantity: ");
                    string quantityInput = Console.ReadLine();
                    if (!double.TryParse(quantityInput, out quantity))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid numeric value for quantity.");
                    }
                } while (quantity <= 0);

                Console.Write("Unit: ");
                string unit = Console.ReadLine();

                ingredients[i] = new Ingredient(name, quantity, unit);
            }

            // Get number of steps from the user
            Console.Write("Enter the number of steps: ");
            int numSteps;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
                {
                    Console.WriteLine("Invalid input! Please enter a valid positive integer for the number of steps.");
                }
            } while (numSteps <= 0);

            // Gets steps from the user and stores them in the array
            Step[] steps = new Step[numSteps];

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step {i + 1}:");
                string description = Console.ReadLine();
                steps[i] = new Step(description);
            }
            // Clear the console screen before displaying the recipe
            Console.Clear();

            // Create and return the recipe
            return new Recipe(recipeName, ingredients, steps);
        }
    }
}
//------------------------------------------------------End of File-----------------------------------------------------------//

