using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeenagerCalculator;

namespace TeenagerCalculatorTest
{
    [TestClass]
    public class TeenagerCalcTest
    {
        [TestMethod]
        [DataRow(1805,05,15)]
        [DataRow(1785,05,15)]
        [DataRow(1500,05,15)]
        [DataRow(1850,05,15)]
        [DataRow(1835,05,15)]
        [DataRow(1425,05,15)]
        [DataRow(1755,05,15)]
        [DataRow(1795,05,15)]
        public void AgeBellowHinderedTwenty(int year, int month, int day)
        {
            ITeenager teenager = new Teenager();
            var ex = Assert.ThrowsException<InvalidOperationException>(() => teenager.IsTeenager(new DateTime(year, month, day)));
            Assert.AreEqual("Sorry dude you are too old to be teenager", ex.Message);
        }

        [TestMethod]
        [DataRow(2022, 12, 24)]
        [DataRow(2122, 12, 24)]
        [DataRow(2222, 12, 24)]
        [DataRow(2035, 12, 24)]
        [DataRow(2025, 12, 24)]
        [DataRow(2029, 12, 24)]
        [DataRow(2023, 12, 24)]
        [DataRow(2031, 12, 24)]
        public void AgeInTheFuture(int year, int month, int day)
        {
            ITeenager teenager = new Teenager();
            var ex = Assert.ThrowsException<InvalidOperationException>(() => teenager.IsTeenager(new DateTime(year,month,day)));
            Assert.AreEqual("You don't even exist yet.", ex.Message);
        }

        [TestMethod]
        [DataRow(2005, 06, 05)]
        [DataRow(2008, 06, 05)]
        [DataRow(2007, 06, 05)]
        [DataRow(2005, 05, 06)]
        [DataRow(2008, 04, 05)]
        [DataRow(2004, 06, 05)]
        [DataRow(2006, 06, 05)]
        [DataRow(2005, 10, 05)]
        public void IsATeenager(int year, int month, int day)
        {
            ITeenager teenager = new Teenager();
            Assert.AreEqual(true, teenager.IsTeenager(new DateTime(year,month,day)));
        }

        [TestMethod]
        [DataRow(1995,05,09)]
        [DataRow(1990,05,09)]
        [DataRow(1955,05,09)]
        [DataRow(1978,05,09)]
        [DataRow(1984,05,09)]
        [DataRow(1992,05,09)]
        [DataRow(2000,05,09)]
        [DataRow(2001,05,09)]
        public void IsNotATeenager(int year, int month, int day)
        {
            ITeenager teenager = new Teenager();
            Assert.AreEqual(false,teenager.IsTeenager(new DateTime(year, month,day)));
        }
    }
}