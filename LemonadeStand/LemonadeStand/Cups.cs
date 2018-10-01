using System;
namespace LemonadeStand
{
    public class Cups : Goods
    {
        public Cups(int value, int quantity)
        {
            this.value = 1;

            this.quantity = quantity;
        }

        public override int Purchase(int purchaseAmmount, int money)
        {
            quantity += purchaseAmmount;
            return quantity;
        }

        public override int UseGood(int[] recipeArray)
        {
            quantity -= recipeArray[2];
            return quantity;
        }
    }
}
