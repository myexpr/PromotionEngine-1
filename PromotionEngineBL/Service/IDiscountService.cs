using PromotionEngineBL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.Service
{
    public interface IDiscountService
    {
        Discount BuyMultipleItemsDiscount(string id);
        Discount BuyTogetherItemsDiscount(string id);
    }
}
