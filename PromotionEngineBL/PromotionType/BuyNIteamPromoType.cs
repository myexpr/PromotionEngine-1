using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.PromotionType
{
    public class BuyNIteamPromoType
    {
        public int CalculateAmount(Product product)
        {
            if (product.Id == SkuIdConstants.AId)
            {
                return (product.Quantity / 3) * 130 + product.Quantity % 3 * ProductPriceConstant.ProductPrice[SkuIdConstants.AId];
            }
            else
            {
                return (product.Quantity / 2) * 45 + product.Quantity % 2 * ProductPriceConstant.ProductPrice[SkuIdConstants.BId];
            }
        }
    }
}
