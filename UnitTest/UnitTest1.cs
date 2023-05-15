using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MyFirstTest;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double start = 1000;
            double c = 960;
            DateTime A1 = new DateTime(2015, 7, 20);
                Assert.AreEqual(c,Convert.ToDouble(MyFirstTest.MainWindow.WeekOfMonth(A1, start)));
        }
        [TestMethod]
        public void TestMethod2()
        {
            double c = 1000;
            DateTime A1 = new DateTime(2015, 7, 1);
            Assert.AreEqual(c, Convert.ToDouble(MyFirstTest.MainWindow.WeekOfMonth(A1, c)));
        }
        [TestMethod]
        public void TestMethod3()
        {
            double c = -960;
            DateTime A1 = new DateTime(2015, 7, 1);
            Assert.AreEqual(0,MyFirstTest.MainWindow.WeekOfMonth(A1, c));
        }
        [TestMethod]
        public void TestMethod4()
        {
            double c = 0;
            DateTime A1 = new DateTime(2015, 7, 20);
            Assert.AreEqual(0, MyFirstTest.MainWindow.WeekOfMonth(A1, c));
        }
        [TestMethod]
        public void TestMethod5()
        {
            double start = (int.MaxValue - (int.MaxValue/100*4));
            double c =int.MaxValue ;
            DateTime A1 = new DateTime(2015, 7, 20);
            Assert.AreEqual(start,MyFirstTest.MainWindow.WeekOfMonth(A1, c));
        }
        [TestMethod]
        public void TestMethod6()
        {
            double start= (double.MaxValue - (double.MaxValue/100*4));
            double c = double.MaxValue;
            DateTime A1 = new DateTime(2015, 7, 20);
            Assert.AreEqual(start, Convert.ToDouble(MyFirstTest.MainWindow.WeekOfMonth(A1, c)));
        }
        [TestMethod]
        public void TestMethod7()
        {
            try
            {
                double c = 960;
                DateTime A1 = new DateTime(-100, 1, 1);
                Assert.IsNotNull(MyFirstTest.MainWindow.WeekOfMonth(A1, c));
            }
            catch (ArgumentOutOfRangeException)
            {

                Assert.Inconclusive("Неверное значение");
            }
          
        }
        [TestMethod]
        public void TestMethod8()
        {
            try
            {
                double c = 960;
                DateTime A1 = new DateTime(0, 1, 1);
                Assert.IsNotNull(MyFirstTest.MainWindow.WeekOfMonth(A1, c));
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.Inconclusive("Неверное значение");
            }
            
        }
        [TestMethod]
        public void TestMethod9()
        {

            double c = 1000;
            double start = 960;
            DateTime A1 = new DateTime(2077, 5, 11);
            // Basket.WeekOfMonth(DateTime.Now, 1000);
            Assert.AreEqual(start,MyFirstTest.MainWindow.WeekOfMonth(A1, c));
        }
        [TestMethod]
        public void TestMethod10()
        {
            double c = long.MaxValue;
            double start = long.MaxValue - (long.MaxValue / 100 * 4);
            DateTime A1 = new DateTime(2015, 7, 20);
            // Basket.WeekOfMonth(DateTime.Now, 1000);
            Assert.AreEqual(start,MyFirstTest.MainWindow.WeekOfMonth(A1, c));
        }
    }
}
