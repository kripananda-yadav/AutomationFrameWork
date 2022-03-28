using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Common
{
    public class BaseClass
    {
        private readonly IWebDriver driver;

        public BaseClass(IWebDriver driver)
        {
               this.driver = driver;
        }
               
        public void Close()
        {
            driver.Close();
        }
        
        public void Wait()
        {
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,600);");

        }
        public void ScrollDownMore()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,680);");

        }

        public void ScrollLittleDown()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,100);");

        }

        public void ScrollLittleUp()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,-50);");

        }
        public void ScrollForRadioButton()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(-345,-286);");

        }
        public void ScrollForAmazonMobile()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(-377,-405);");

        }


        public void ScrollUp()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,-400);");

        }

        public void SwitchTab()
        {
            driver.SwitchTo().Window(driver.WindowHandles[1]);
        }
        
    }
}
