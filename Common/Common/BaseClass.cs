using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public abstract class BaseClass
    {
       protected IWebDriver driver = new ChromeDriver();

    }
  
    
}
