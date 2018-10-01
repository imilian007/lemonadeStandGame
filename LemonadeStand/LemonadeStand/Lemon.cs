using System;
namespace LemonadeStand
{
    public class Lemon : Goods
    {
        public Lemon(int value, int quantity)
        {
            this.value = 2;

            this.quantity = quantity;
        }

        public override int Purchase(int purchaseAmmount, int money)
        {
            if (purchaseAmmount * value < money)
            {
                quantity = quantity + purchaseAmmount;
            }
            return quantity;
        }

        public override int UseGood(int[] recipeArray)
        {
            quantity -= recipeArray[0];
            return quantity;
        }
    }
}
