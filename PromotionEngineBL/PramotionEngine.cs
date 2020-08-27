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

            totalAmt = products.FirstOrDefault(x => x.Id == SkuIdConstants.AId).Quantity * ProductPriceConstant.ProductPrice[SkuIdConstants.AId];

            return totalAmt;
        }
    }
}
