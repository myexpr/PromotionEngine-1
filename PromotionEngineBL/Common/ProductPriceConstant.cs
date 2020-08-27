using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngineBL.Common
{
    public static class ProductPriceConstant
    {
        public static readonly Dictionary<string, int> ProductPrice
            = new Dictionary<string, int>
            {
                { SkuIdConstants.AId,50},
                { SkuIdConstants.BId,30},
                { SkuIdConstants.CId,20},
                { SkuIdConstants.DId,15}
            };
    }
}
