using QALab.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QALab.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace QALab.Methods
{
    public class MainMethods : BaseObject
    {
        public static void Authorization(string login, string password)
        {
            driver.FindElementById(Home_Page.INPUT_LOGIN).SendKeys(login);
            driver.FindElementById(Home_Page.INPUT_PASSWORD).SendKeys(password);
            driver.FindElementById(Home_Page.BUTTON_LOGIN).Click();
			
		}

        public static void SendMessage(string to="google@google.com", string theme="new theme")
        {
			Utils.WaitForPageReady();
			Utils.Wait(By.XPath(Home_Page.BUTTON_START_SEND_MESSAGE));
			driver.FindElementByXPath(Home_Page.BUTTON_START_SEND_MESSAGE).Click();
			Utils.WaitForPageReady();
			Utils.Wait(By.XPath(Home_Page.INPUT_TO_SEND));
			driver.FindElementByXPath(Home_Page.INPUT_TO_SEND).SendKeys(to);
			driver.FindElementByXPath(Home_Page.INPUT_THEME_MESSAGE).SendKeys(theme);
			driver.FindElementByXPath(Home_Page.BUTTON_SEND_MESSAGE).Click();
			Utils.WaitForElementEnabled(By.XPath(Home_Page.BUTTON_ACCEPT_NULL_DESCRITPION));
			driver.FindElementByXPath(Home_Page.BUTTON_ACCEPT_NULL_DESCRITPION).Click();
			Utils.WaitForPageReady();
			Utils.Wait(By.XPath(Home_Page.LABEL_MESSAGE_SEND));
			Assert.IsNotNull(driver.FindElementByXPath(Home_Page.LABEL_MESSAGE_SEND));
        }
    }
}
