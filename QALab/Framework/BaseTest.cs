using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALab.Framework
{
    [TestClass]
    public class BaseTest : BaseObject
    {

        [TestInitialize]
        public void SetupTest()
        {
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            driver.Quit();
        }
	}

}
