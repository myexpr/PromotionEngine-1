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


        #region Basic Senario
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

        [Test]
        public void Buy_A_And_B_Product_Quantity_1_Should_Return_80()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.AId,Quantity=1},
                new Product{Id = SkuIdConstants.BId,Quantity=1}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(80, totalAmt);
        }

        [Test]
        public void Buy_C_Product_Quantity_1_Should_Return_20()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.CId,Quantity=1}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(20, totalAmt);
        }
        public void Buy_D_Product_Quantity_1_Should_Return_15()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.DId,Quantity=1}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(15, totalAmt);
        }

        #endregion


        #region Combine Buy Discount
        [Test]
        public void Buy_A_Product_Quantity_3_Should_Return_130_With_Discount()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.AId,Quantity=3}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(130, totalAmt);
        }

        [Test]
        public void Buy_B_Product_Quantity_2_Should_Return_45_With_Discount()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.BId,Quantity=2}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(45, totalAmt);
        }

        [Test]
        public void Buy_A_Product_Quantity_4_Should_Return_180_With_Discount()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.AId,Quantity=4}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(180, totalAmt);
        }


        [Test]
        public void Buy_A_and_B_Product_Quantity_A4_B3_Should_Return_255_With_Discount()
        {
            //Arrange
            List<Product> products = new List<Product>
            {
                new Product{Id = SkuIdConstants.AId,Quantity=4},
                new Product{Id = SkuIdConstants.BId,Quantity=3}
            };

            //Act
            int totalAmt = pramotionEngine.GetTotalBill(products);

            //Asert
            Assert.AreEqual(255, totalAmt);
        }

        #endregion


    }
}