using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.Service
{
    public class DiscountService : IDiscountService
    {
        public Discount BuyMultipleItemsDiscount(string id)
        {
            switch (id)
            {
                case SkuIdConstants.AId:
                    return new Discount { Quanity = 3, FixedRate = 130 };
                case SkuIdConstants.BId:
                    return new Discount { Quanity = 2, FixedRate = 45 };
                default:
                    return new Discount();
            }
        }

        public Discount BuyTogetherItemsDiscount(string id)
        {
            switch (id)
            {
                case SkuIdConstants.CId:
                case SkuIdConstants.DId:
                    return new Discount { Quanity = 1, FixedRate = 30 };
                default:
                    return new Discount();
            }
        }
    }
}
