using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    public class Tennis
    {
        public bool CheckSameOrNot(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public bool isDeuce(int a, int b)
        {
            if (a > 3 && b > 3)
            {
                if (a == b)
                {
                    return true;
                }
            }
            return false;
        }

        public bool isGamePoint(int a, int b)
        {
            if (a > 3 || b > 3)
            {
                return true;
            }
            return false;
        }

        public string ResultAll(int a, int b)
        {
            var str = "";
            switch (a)
            {
                case 1:
                    str = "15:15";
                    break;

                case 2:
                    str = "20:20";
                    break;

                case 3:
                    str = "30:30";
                    break;

                default:
                    str = "The result is not all.";
                    break;
            }

            return str;
        }

        public string ResultDeuce(bool a)
        {
            var str = "Deuce";

            return str;
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSameOrNot()
        {
            var tennis = new Tennis();
            var isSame = tennis.CheckSameOrNot(3, 3);
            Assert.AreEqual(true, isSame);
        }

        [TestMethod]
        public void isDeuce()
        {
            var tennis = new Tennis();
            var deuce = tennis.isDeuce(4, 4);
            Assert.AreEqual(true, deuce);
        }

        public void isGamePoint()
        {
            var tennis = new Tennis();
            var gamePoint = tennis.isGamePoint(4, 3);
            Assert.AreEqual(true, gamePoint);
        }

        [TestMethod]
        public void ResultAll()
        {
            var tennis = new Tennis();
            var resultAll = tennis.ResultAll(3, 3);
            Assert.AreEqual("30:30", resultAll);
        }

        [TestMethod]
        public void ResultDeuce()
        {
            var tennis = new Tennis();
            var resultDeuce = tennis.ResultDeuce(true);
            Assert.AreEqual("Deuce", resultDeuce);
        }
    }
}