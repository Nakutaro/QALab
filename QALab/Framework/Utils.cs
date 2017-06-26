using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QALab.Framework
{
	public class Utils : BaseObject
	{
		public static void WaitForPageReady()
		{
			IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			wait.Until(Driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
		}

		public static void Wait(By by)
		{
			IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			wait.Until(Driver1 => { return driver.FindElement(by); });
		}

		/// <summary>Ожидание заверешения полной загрузки страницы с проверкой на "тривиальные" ошибки.
		/// <para>В качестве параметра метода можно указать значение, которое должно присутствовать на загружаемой странице.</para> 
		/// </summary>
		/// <param name="text">использование метода PageSource.Contains()</param>
		public static void Inspection(string text = "")
		{
			// ожидание завершения загрузки страницы
			IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
			wait.Until(Driver1 => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
			// ожидание завершения выполнения ajax запросов
			wait.Until(drv => (bool)(drv as IJavaScriptExecutor).ExecuteScript("return window.jQuery != undefined && jQuery.active==0")); // 
																																		  // проверка на наличие ошибок
			Assert.IsFalse(driver.PageSource.Contains("Exception:"), "Exception на странице: " + driver.Url);
			Assert.IsFalse(driver.PageSource.Contains("Невозможно выполнить действие"), "Ошибка на странице: " + driver.Url);
			Assert.IsFalse(driver.PageSource.Contains("Ошибка доступа"), "Ошибка доступа: " + driver.Url);
			Assert.IsFalse(driver.PageSource.Contains("К сожалению, произошла ошибка"), "Ошибка на странице: " + driver.Url);
			if (!string.IsNullOrEmpty(text)) Assert.IsTrue(driver.PageSource.Contains(text), "Значение \"" + text + "\"" + " в исходном тексте страницы " + driver.Url + " не найдено.");
		}

		public static void WaitForElementEnabled(By by)
		{
			IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(Driver1 => { return driver.FindElement(by).Enabled; });
		}
	}
}
