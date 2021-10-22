using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Selenium.Page_object_model.PageObjects
{
    class GoogleSearchResultPage
    {
        private IWebDriver driver;
       

        public GoogleSearchResultPage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public IWebElement result => driver.FindElement(By.Id("result-stats"));
        public IWebElement time => driver.FindElement(By.CssSelector("#result-stats > nobr"));

        public GoogleSearchResultPage results()
        {


            string a = result.Text;
            string b = time.Text;
            string c = result.Text.Remove(a.Length - b.Length);
            Console.WriteLine($"Result: " + c);
            return this;
            
        }

    }

    
}
