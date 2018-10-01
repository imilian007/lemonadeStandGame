using System;
namespace LemonadeStand
{
    public class Customer
    {
        public Customer()
        {
        }
        public int purchaseProbability = 0;

        public void DetermineProbability(string weather, int price, int reputation)
        {
            switch(weather)
            {
                case "Humid":
                    purchaseProbability = 70 + reputation - (price * 10);
                    break;

                case "Rainy":
                    purchaseProbability = 55 + reputation - (price * 13);
                    break;

                case "Dry":
                    purchaseProbability = 75 + reputation - (price * 8);
                    break;

                case "Snowy":
                    purchaseProbability = 30 + reputation - (price * 13);
                    break;
            }

            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            purchaseProbability = (randomNumber + purchaseProbability) / 2;
        }
    }
}
