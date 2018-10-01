using System;
namespace LemonadeStand
{
    public class Recipe
    {
        public Recipe()
        {
        }

        int numberOfLemons = 0;

        int ammountOfSugar = 0;

        public int price = 0;

        public void CreateRecipe()
        {
            Console.WriteLine("How many Lemons in your recipe?");
            
            numberOfLemons = int.Parse(Console.ReadLine());

            Console.WriteLine("How many cups of sugar in your recipe?");
            ammountOfSugar = int.Parse(Console.ReadLine());

            Console.WriteLine("How much will you charge for your lemonade? (must be an integer, no decimals)");
            while(price%1 != 0)
            price = int.Parse(Console.ReadLine());
        }
    }
}
