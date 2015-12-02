using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NLog;
using NLog.Config;


namespace Episode_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://www.google.com";
           
            var searchBox = driver.FindElement(By.Name("q"));
            //Looks for the correct site.

            searchBox.SendKeys("adblock plus");
            

            //searchBox.SendKeys("animefreak.tv");

            searchBox.Submit();

           var searchButton = driver.FindElement(By.ClassName("lsb"));
           searchButton.Click();

          



            //Find the results of our query
           driver.FindElement(By.LinkText("Adblock Plus - Surf the web without annoying ads!")).Click();           

            

            
        }

     
    }
}
