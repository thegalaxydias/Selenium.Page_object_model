using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

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


        public GoogleSearchResultPage Search (string value)
        {
            search.SendKeys(value);
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementToBeClickable(button));

            
            button.Click();
            return new GoogleSearchResultPage(driver);
        }
    }

    
}
