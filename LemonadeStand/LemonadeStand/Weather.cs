using System;
namespace LemonadeStand
{
    public class Weather
    {
        public Weather()
        {
        }

        public string DetermineWeather()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);

            string weather = "Tornado";

            switch (randomNumber)
            {
                case 1:
                    weather = "Humid";
                    break;

                case 2:
                    weather = "Rainy";
                    break;

                case 3:
                    weather = "Dry";
                    break;

                case 4:
                    weather = "Snowy";
                    break;
            }
            return weather;
        }
    }
}
