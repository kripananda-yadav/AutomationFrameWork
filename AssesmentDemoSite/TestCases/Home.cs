using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssesmentDemoSite.Common;

namespace AssesmentDemoSite.TestCases
{
    public class Home
    {
       static IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {




            NavigateToDemoSite();
            //Navigate to the Amazon Page

/*
            IWebElement element = driver.FindElement(By.Name("a"));
            element.Click();*/

            //   driver.Close();
        }


        [Test]
        public static void NavigateToDemoSite()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/");
            LocatorsAction.CLickOnWebElement(driver, "//h5[contains(text(),'Alerts, Frame & Windows')]", "XPath");
        }
    }
}
