using System;
namespace LemonadeStand
{
    public class Market
    {
        int lemons = 0;

        int sugar = 0;

        int cups = 0;

        public Market()
        {
        }

        public void DisplayMoney(int money)
        {
            Console.WriteLine("You have: {0}", money);
        }

        public void DisplayForecast(string weather)
        {
            Console.WriteLine("Forecast for tomorrow is: {0}", weather);
        }

        public Array CreateRecipe(int lemons, int sugar, int cups)
        {

        }

        public int PurchaseGoods(int specificGood)
        {

        }
    }
}
