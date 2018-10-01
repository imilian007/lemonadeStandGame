using System;
namespace LemonadeStand
{
    public class Day
    {
        public Day()
        {
        }

        public int dayNumber = 0;

        public int dayCounter = 0;

        public string dayWeather;

        public int numberOfCustomers;

        public int probability;

        Weather weather = new Weather();

        Customer customer = new Customer();

        private void DisplayDay()
        {
            Console.WriteLine("{0}", dayNumber);
        }

        private int IncrementDay(int currentDay)
        {
            currentDay++;
            return currentDay;
        }

        public void DetermineWeather()
        {
            dayWeather = weather.DetermineWeather();

            weather.DisplayForecast(dayWeather);
        }

        public void DetermineProbability(string weather, int price, int reputation)
        {
            customer.DetermineProbability(weather, price, reputation);

            probability = customer.purchaseProbability;
        }

        public int NumberOfCustomers()
        {
            Random random = new Random();
            int randomNumber = random.Next(50, 100);

            return randomNumber;
        }
    }
}
