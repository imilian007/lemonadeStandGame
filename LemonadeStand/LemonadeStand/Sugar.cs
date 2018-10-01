using System;
namespace LemonadeStand
{
    public class Sugar : Goods
    {
        public Sugar(int value, int quantity)
        {
            this.value = 1;

            this.quantity = quantity;
        }

        public override int Purchase(int purchaseAmmount, int money)
        {
            quantity = quantity + purchaseAmmount;
            return quantity;
        }

        public override int UseGood(int[] recipeArray)
        {
            quantity -= recipeArray[1];
            return quantity;
        }
    }
}
