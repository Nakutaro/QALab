using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QALab.Framework;
using QALab.Methods;

namespace QALab.Tests
{
    [TestClass]
    public class Tests : BaseTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("https://mail.ru/");
            MainMethods.Authorization("forqalab", "123aaa123");
            MainMethods.SendMessage();
        }
    }
}
