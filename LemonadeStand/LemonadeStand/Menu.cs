using System;
namespace LemonadeStand
{
    public class Menu
    {
        public Menu()
        {
        }

        int numberOfDays = 7;
        int numberOfPlayers = 1;

        public int NumberOfDays
        {
            get => numberOfDays;

            set => numberOfDays = value;
        }

        public int NumberOfPlayers
        {
            get => numberOfPlayers;

            set => numberOfPlayers = value;
        }

        public int GetPlayers()
        {
            int playerCount = 0;

            while(playerCount != 1 && playerCount != 2)
            {
                Console.WriteLine("How many players? ('1' or '2')");
                playerCount = int.Parse(Console.ReadLine());
            }
            return playerCount;
        }

        public int GetDays()
        {
            int dayCount = 0;

            while(dayCount != 7 && dayCount != 14 && dayCount != 31)
            {
                Console.WriteLine("How many days? ('7', '14', or '31')");
                dayCount = int.Parse(Console.ReadLine());
            }
            return dayCount;
        }
    }
}
