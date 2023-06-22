using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestClass]
        public class OrderAnalyzerTests
        {
            //1 тест
            [TestMethod]
            public void GetPopularMonths_ReturnsCorrectListOfPopularMonths_WhenOrderDatesAreProvided()
            {
                List<DateTime> orderDates = new List<DateTime>
            {
                new DateTime(2019, 12, 12, 14, 43, 0),
                new DateTime(2019, 12, 1, 15, 5, 0),
                new DateTime(2019, 11, 4, 9, 1, 0)
            };

                List<DateTime> popularMonths = OrderAnalyzer.GetPopularMonths(orderDates);

                Assert.AreEqual(2, popularMonths.Count);
                Assert.AreEqual(new DateTime(2019, 12, 1), popularMonths[0]);
                Assert.AreEqual(new DateTime(2019, 11, 1), popularMonths[1]);
            }
        }
        //2 тест
        [TestMethod]
        public void GetPopularMonths_ReturnsSingleMonth_WhenOrderDatesContainOnlyOneMonth()
        {
            List<DateTime> orderDates = new List<DateTime>
            {
                new DateTime(2022, 6, 10, 8, 0, 0),
                new DateTime(2022, 6, 15, 14, 30, 0),
                new DateTime(2022, 6, 25, 10, 0, 0)
            };

            List<DateTime> popularMonths = OrderAnalyzer.GetPopularMonths(orderDates);

            Assert.AreEqual(1, popularMonths.Count);
            Assert.AreEqual(new DateTime(2022, 6, 1), popularMonths[0]);
        }
    }


}