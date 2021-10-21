using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using Selenium.Page_object_model.PageObjects;

namespace Selenium.Page_object_model
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");

            GoogleHomePage googleHomePage = new GoogleHomePage(driver);
            googleHomePage.Search("IT Craft");


            Console.Clear();
            GoogleSearchResultPage googleSearchResultPage = new GoogleSearchResultPage(driver);
            googleSearchResultPage.results();

           
          
            driver.Quit();
        }
    }
}
