using NUnit.Framework;
using PromotionEngineBL;
using PromotionEngineBL.Common;
using PromotionEngineBL.Model;
using System.Collections.Generic;

namespace PromotionEngineBLTest
{
    public class PramotionEngineTest
    {
        PramotionEngine pramotionEngine;

        [SetUp]
        public void Setup()
        {
            pramotionEngine = new PramotionEngine();
        }

        [Test]
        public void Buy_A_Product_Quantity_1_Should_Return_50()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.AId,Quantity=1}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(50, totalAmt);
        }

        [Test]
        public void Buy_B_Product_Quantity_1_Should_Return_30()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.BId,Quantity=1}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(30, totalAmt);
        }

    }
}