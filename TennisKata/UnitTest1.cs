using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisKata
{
    public class Tennis
    {
        public string Adv(string a)
        {
            return a + " Adv";
        }

        public bool CheckSameOrNot(int a, int b)
        {
            if (a == b)
            {
                return true;
            }
            return false;
        }

        public string DiffScoreReport(int a, int b)
        {
            var result = "";
            if (a <= 3 && b <= 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    var count = i == 0 ? a : b;
                    switch (count)
                    {
                        case 0:
                            result += count.ToString();
                            break;

                        case 1:
                            result += count.ToString() + "5";
                            break;

                        default:
                            result += (count + 1).ToString() + "0";
                            break;
                    }

                    result += i == 0 ? ":" : "";
                }

                return result;
            }

            return result + "one score is over 40.";
        }

        public bool isAdv(int a, int b)
        {
            if (Math.Abs(a - b) == 1)
            {
                return true;
            }
            return false;
        }

        public bool isDeuce(int a, int b)
        {
            if (a > 2 && b > 2)
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
                case 0:
                    str = "0:0";
                    break;

                case 1:
                    str = "15:15";
                    break;

                case 2:
                    str = "30:30";
                    break;

                default:
                    str = "The result is over 40.";
                    break;
            }

            return str;
        }

        public string ResultDeuce(bool a)
        {
            var str = "Deuce";

            return str;
        }

        public string Win(string a)
        {
            return a + " Wins";
        }
    }

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Adv()
        {
            var tennis = new Tennis();
            var adv = tennis.Adv("April");
            Assert.AreEqual("April Adv", adv);
        }

        [TestMethod]
        public void CheckSameOrNot()
        {
            var tennis = new Tennis();
            var isSame = tennis.CheckSameOrNot(2, 2);
            Assert.AreEqual(true, isSame);
        }

        [TestMethod]
        public void DiffScoreReport()
        {
            var tennis = new Tennis();
            var diffScoreReport = tennis.DiffScoreReport(5, 7);
            Assert.AreEqual("one score is over 40.", diffScoreReport);
        }

        [TestMethod]
        public void isAdv()
        {
            var tennis = new Tennis();
            var isAdv = tennis.isAdv(3, 2);
            Assert.AreEqual(true, isAdv);
        }

        [TestMethod]
        public void isDeuce()
        {
            var tennis = new Tennis();
            var deuce = tennis.isDeuce(3, 3);
            Assert.AreEqual(true, deuce);
        }

        [TestMethod]
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
            var resultAll = tennis.ResultAll(2, 2);
            Assert.AreEqual("30:30", resultAll);
        }

        [TestMethod]
        public void ResultDeuce()
        {
            var tennis = new Tennis();
            var resultDeuce = tennis.ResultDeuce(true);
            Assert.AreEqual("Deuce", resultDeuce);
        }

        [TestMethod]
        public void Win()
        {
            var tennis = new Tennis();
            var win = tennis.Win("April");
            Assert.AreEqual("April Wins", win);
        }
    }
}