using System;
namespace LemonadeStand
{
    public class Game
    {
        public Game()
        {
        }

        Player playerOne = new Player();

        Rules rules = new Rules();

        Menu menu = new Menu();

        Day day = new Day();

        public void RunGame()
        {
            rules.DisplayRules();

            day.dayCounter = menu.GetDays();

            while(day.dayNumber < day.dayCounter)
            {
                playerOne.DisplayMoney();

                day.DetermineWeather();

                playerOne.PurchaseGoods();

                playerOne.CreateRecipe();


                day.DetermineProbability(day.dayWeather, playerOne.price, playerOne.reputation);

                day.numberOfCustomers = day.NumberOfCustomers();

                while(day.numberOfCustomers > 0)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 100);

                    if(randomNumber > day.probability)
                    {
                        playerOne.money += playerOne.price;
                    }

                    day.numberOfCustomers--;
                }

                playerOne.DetermineProfit();

                playerOne.DisplayProfit();
            }

            playerOne.DisplayTotalProfit();
        }
    }
}
