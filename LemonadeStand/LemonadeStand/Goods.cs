using System;
namespace LemonadeStand
{
    public abstract class Goods
    {
        protected int value = 0;

        public int quantity = 0;

        public Goods()
        {
        }

        public abstract int Purchase(int purchaseAmmount, int money);

        public abstract int UseGood(int[] recipeArray);
    }
}
