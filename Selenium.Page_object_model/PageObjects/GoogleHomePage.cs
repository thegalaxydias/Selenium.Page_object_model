using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace Selenium.Page_object_model.PageObjects
{
    class GoogleHomePage
    {
        private IWebDriver driver;
       

        public GoogleHomePage(IWebDriver driver) 
        {
            this.driver = driver;
            
            }
        public IWebElement search => driver.FindElement(By.CssSelector("input[type=text]"));
        public IWebElement button => driver.FindElement(By.CssSelector("input[type=submit]"));


        public void Search(string value)
        {
            search.SendKeys(value);
            button.Click();
        }
    }

    
}
