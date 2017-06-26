using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QALab.Framework
{
	public class BaseObject
	{
		public static RemoteWebDriver driver = new ChromeDriver();
	}
}
