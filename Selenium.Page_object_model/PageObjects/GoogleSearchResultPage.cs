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

        public void results()
        {
            //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            //wait.Until(ExpectedConditions.invisibilityOf(result));

            string a = result.Text;
            string b = time.Text;
            Console.WriteLine(a.Length - b.Length);
            
        }

    }

    
}
