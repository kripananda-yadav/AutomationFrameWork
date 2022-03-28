using AssesmentDemoSite.PageServices;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Common
{
    public  class Navigate
    {
        private readonly IWebDriver driver;

        public Navigate(IWebDriver driver)
        {
            this.driver = driver;
        }
        public  void GoToUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);

        }

        public void Close()
        {
            driver.Close();
        }

       

    }
}
