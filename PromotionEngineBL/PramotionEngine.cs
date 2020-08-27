using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngineBL
{
    public class PramotionEngine
    {
        public int GetTotalBill(List<Product> products)
        {
            int totalAmt = 0;

            foreach (var item in products)
            {
                totalAmt += item.Quantity * ProductPriceConstant.ProductPrice[item.Id];
            }
            return totalAmt;
        }
    }
}
