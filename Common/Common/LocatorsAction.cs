using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using Common.Common;

namespace AssesmentDemoSite.Common
{
    public class LocatorsAction:BaseClass
    {
        //Enter Text in any input fields
        public  void EnterText(string element, string value, string elementType )
        {
            if(elementType=="Id")
                 driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(value);
            if (elementType == "Xpath")
                driver.FindElement(By.XPath(element)).SendKeys(value);
            if (elementType == "CssSelector")
                driver.FindElement(By.CssSelector(element)).SendKeys(value);

        }

        //Clicking any element on the page 
        public  void CLickOnWebElement( string element,  string elementType)
        {
            
                if (elementType == "Id")
                    driver.FindElement(By.Id(element)).Click();
                if (elementType == "Name")
                    driver.FindElement(By.Name(element)).Click();
                if (elementType == "Xpath")
                    driver.FindElement(By.XPath(element)).Click();
                if (elementType == "CssSelector")
                    driver.FindElement(By.CssSelector(element)).Click();

            


            
        }

        //Selecting a drop down control
        public  void DropDownSelection( string element, string value, string elementType)
        {
            if (elementType == "Id")
               new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);
            if (elementType == "Xpath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
            if (elementType == "CssSelector")
                new SelectElement(driver.FindElement(By.CssSelector(element))).SelectByText(value);

        }

    }
}
