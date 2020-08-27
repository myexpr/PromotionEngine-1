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
            if (productC == null && productD == null)
                return 0;

            int finalAmt = 0;
            if (productC != null && productD == null)
            {
                return productC.Quantity * ProductPriceConstant.ProductPrice[SkuIdConstants.CId];
            }
            else if (productD != null && productC == null)
            {
                return productD.Quantity * ProductPriceConstant.ProductPrice[SkuIdConstants.DId];
            }
            else
            {
                int diff = productC.Quantity - productD.Quantity;

                if (diff > 0)
                {
                    finalAmt = diff * ProductPriceConstant.ProductPrice[SkuIdConstants.CId] +
                                (productD.Quantity * 30);
                }
                else if (diff < 0)
                {
                    finalAmt = Math.Abs(diff) * ProductPriceConstant.ProductPrice[SkuIdConstants.DId] +
                                (productC.Quantity * 30);

                }
                else
                {
                    finalAmt = productD.Quantity * 30;
                }
            }
            return finalAmt;
        }
    }
}
