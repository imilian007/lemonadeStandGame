using System;
namespace LemonadeStand
{
    public class Menu
    {
        public Menu()
        {
        }

        int numberOfDays = 7;

        public int NumberOfDays
        {
            get => numberOfDays;

            set => numberOfDays = value;
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
