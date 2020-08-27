using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.PromotionType
{
    public class BuyTwoItemsPromoType
    {
        public int CalculateAmount(Product productC, Product productD)
        {
            int finalAmt = 0;
            if (productC != null && productD == null)
            {
                return productC.Quantity * ProductPriceConstant.ProductPrice[SkuIdConstants.CId];
            }
            else if (productD != null && productC == null)
            {
                return productD.Quantity * ProductPriceConstant.ProductPrice[SkuIdConstants.DId];
            }
            return finalAmt;
        }
    }
}
