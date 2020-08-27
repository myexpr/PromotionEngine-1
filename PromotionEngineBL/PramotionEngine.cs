using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using PromotionEngineBL.PromotionType;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineBL
{
    public class PramotionEngine
    {
        private BuyNIteamPromoType buyNIteamPromoType;
        public PramotionEngine()
        {
            buyNIteamPromoType = new BuyNIteamPromoType();
        }

        public int GetTotalBill(List<Product> products)
        {
            int totalAmt = 0;

            foreach (var item in products)
            {
                totalAmt += buyNIteamPromoType.CalculateAmount(item);
            }
            return totalAmt;
        }
    }
}
