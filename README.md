Recipe App
Welcome to the Recipe App, a command-line application for creating, managing, and scaling recipes!

Table of Contents:
-Introduction
-Features
-Requirements
-Installation
-Usage
-How to use


Introduction
The Recipe App is a simple command-line application written in C# that allows users to create and manage recipes. It provides functionalities to add ingredients, steps, scale the recipe, reset ingredient quantities, and start a new recipe.

Features
-Create new recipes with ingredients and steps
-Display recipes with neat formatting
-Scale recipe by a factor (0.5 for half, 2 for double, 3 for triple)
-Reset ingredient quantities to original values
-Clear current recipe and start a new one



Requirements
-.NET Core SDK installed on your machine.

-Installation
--Clone this repository to your local machine using git clone.
--Navigate to the project directory.

Usage
-Open your terminal or command prompt.
-Navigate to the project directory.
-Run the application using the following command: "dotnet run"
-Follow the on-screen prompts to create, manage, and scale recipes.

How to use
-once running you follow the prompts to create your first recipe
-after this it will display your recipe with a few options
-these options are: 1. scale the recipe values
                    2. reset the values to original after scaling
                    3.clear existing recipe and start a new one
                    4 exit application
-if you choose 1, you must enter a numeric value that you want your recipe to be scaled by... once selected it will show the updated scaled recipe
-if you choose 2 it will revert any scaled measurements to the original values you entered
-if you choose 3 it will clear your current recipe and allow you to make a new one
-if you choose 4 it will close the command line application and stop running the code

Thank you!
