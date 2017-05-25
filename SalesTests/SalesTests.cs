using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales;

namespace Sales.Tests
{
    [TestClass()]
    public class SalesTests
    {
        [TestMethod()]
        public void vaild_Sales_getSumTest_by_termName_Cost_termNumber_4()
        {
            Sales testSales = new Sales();
            int[] expected = new int[4];
            expected[0] = 6;
            expected[1] = 15;
            expected[2] = 24;
            expected[3] = 21;

            List<saleList> testSaleList = new List<saleList>();
            testSaleList.Add(new saleList() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            testSaleList.Add(new saleList() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            testSaleList.Add(new saleList() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            testSaleList.Add(new saleList() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            testSaleList.Add(new saleList() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            testSaleList.Add(new saleList() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            testSaleList.Add(new saleList() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            testSaleList.Add(new saleList() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            testSaleList.Add(new saleList() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            testSaleList.Add(new saleList() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            testSaleList.Add(new saleList() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            int[] actual = testSales.getSum(testSaleList, "Cost", 4);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void vaild_Sales_getSumTest_by_termName_Revenue_termNumber_3()
        {
            Sales testSales = new Sales();
            int[] expected = new int[3];
            expected[0] = 50;
            expected[1] = 66;
            expected[2] = 60;

            List<saleList> testSaleList = new List<saleList>();
            testSaleList.Add(new saleList() { Id = 1, Cost = 1, Revenue = 11, SellPrice = 21 });
            testSaleList.Add(new saleList() { Id = 2, Cost = 2, Revenue = 12, SellPrice = 22 });
            testSaleList.Add(new saleList() { Id = 3, Cost = 3, Revenue = 13, SellPrice = 23 });
            testSaleList.Add(new saleList() { Id = 4, Cost = 4, Revenue = 14, SellPrice = 24 });
            testSaleList.Add(new saleList() { Id = 5, Cost = 5, Revenue = 15, SellPrice = 25 });
            testSaleList.Add(new saleList() { Id = 6, Cost = 6, Revenue = 16, SellPrice = 26 });
            testSaleList.Add(new saleList() { Id = 7, Cost = 7, Revenue = 17, SellPrice = 27 });
            testSaleList.Add(new saleList() { Id = 8, Cost = 8, Revenue = 18, SellPrice = 28 });
            testSaleList.Add(new saleList() { Id = 9, Cost = 9, Revenue = 19, SellPrice = 29 });
            testSaleList.Add(new saleList() { Id = 10, Cost = 10, Revenue = 20, SellPrice = 30 });
            testSaleList.Add(new saleList() { Id = 11, Cost = 11, Revenue = 21, SellPrice = 31 });

            int[] actual = testSales.getSum(testSaleList, "Revenue", 3);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}