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
        private BuyTwoItemsPromoType buyTwoItemsPromoType;

        public PramotionEngine()
        {
            buyNIteamPromoType = new BuyNIteamPromoType();
            buyTwoItemsPromoType = new BuyTwoItemsPromoType();
        }

        public int GetTotalBill(List<Product> products)
        {
            int totalAmt = 0;

            // This loop will work from Only Product A and Prodcut B
            foreach (var item in products.Where(x => x.Id == SkuIdConstants.AId || x.Id == SkuIdConstants.BId))
            {
                totalAmt += buyNIteamPromoType.CalculateAmount(item);
            }

            totalAmt += buyTwoItemsPromoType.CalculateAmount
                (products.Find(x => x.Id == SkuIdConstants.CId), 
                 products.Find(x => x.Id == SkuIdConstants.DId));

            return totalAmt;
        }
    }
}
