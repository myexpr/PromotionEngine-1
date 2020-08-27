using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using PromotionEngineBL.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.PromotionType
{
    public class BuyNIteamPromoType
    {
        IDiscountService discountService;

        public BuyNIteamPromoType(IDiscountService _discountService)
        {
            discountService = _discountService;
        }

        public int CalculateAmount(Product product)
        {
            int productPrice = ProductPriceConstant.ProductPrice[product.Id];
            Discount discount = discountService.BuyMultipleItemsDiscount(product.Id);
            return 
                (product.Quantity / discount.Quanity) * discount.FixedRate 
                + (product.Quantity % discount.Quanity * productPrice);
        }
    }
}
