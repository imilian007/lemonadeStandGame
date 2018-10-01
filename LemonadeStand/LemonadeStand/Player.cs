using System;
namespace LemonadeStand
{
    public class Player
    {
        public int money;

        int startingMoney;

        int profit;

        public int reputation;

        public int price;

        public Player()
        {
            this.money = 20;
        }

        Recipe recipe = new Recipe();

        Goods lemon = new Lemon(2, 0);

        Goods sugar = new Sugar(1, 0);

        Goods cups = new Cups(1, 0);


        public void PurchaseGoods()
        {
            Console.WriteLine("How many lemons would you like to buy? ($2 each)");
            lemon.quantity = lemon.Purchase(int.Parse(Console.ReadLine()), money);

            Console.WriteLine("How many cups of sugar would you like to buy? ($1/cup)");
            sugar.quantity = lemon.quantity = sugar.Purchase(int.Parse(Console.ReadLine()), money);

            Console.WriteLine("How many cups would you like to buy? ($1 for 10, must buy in multiples of 10)");
            cups.quantity = cups.Purchase(int.Parse(Console.ReadLine()), money);
        }

        public void DisplayMoney()
        {
            Console.WriteLine("You have: {0}", money);
        }

        public void CreateRecipe()
        {
            recipe.CreateRecipe();
            price = recipe.price;
        }

        public void DetermineProfit()
        {
            profit = money - startingMoney;
            startingMoney = money;
        }

        public void DisplayProfit()
        {
            Console.WriteLine("Profit: {0}", profit);
        }

        public void DisplayTotalProfit()
        {
            Console.WriteLine("Your total profit was {0}", money - 20);
        }
    }
}
