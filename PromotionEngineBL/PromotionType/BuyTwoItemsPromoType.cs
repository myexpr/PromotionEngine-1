using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using PromotionEngineBL.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.PromotionType
{
    public class BuyTwoItemsPromoType
    {

        IDiscountService discountService;

        public BuyTwoItemsPromoType(IDiscountService _discountService)
        {
            discountService = _discountService;
        }


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
                                (productD.Quantity * discountService.BuyTogetherItemsDiscount(productC.Id).FixedRate);
                }
                else if (diff < 0)
                {
                    finalAmt = Math.Abs(diff) * ProductPriceConstant.ProductPrice[SkuIdConstants.DId] +
                                (productC.Quantity * discountService.BuyTogetherItemsDiscount(productC.Id).FixedRate);

                }
                else
                {
                    finalAmt = productD.Quantity * discountService.BuyTogetherItemsDiscount(productC.Id).FixedRate;
                }
            }
            return finalAmt;
        }
    }
}
