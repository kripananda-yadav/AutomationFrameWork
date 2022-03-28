using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Common.Common
{
    public  class Navigate:BaseClass
    {
     public void GoToUrl(string Url)
        {
            driver.Navigate().GoToUrl(Url);

        }
    }
}
