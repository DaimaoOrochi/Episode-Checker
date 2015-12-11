using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NLog;
using NLog.Config;
using OpenQA.Selenium.Interactions;


namespace Episode_Checker
{
    class Program
    {
        private static void Main(string[] args)
        {
            
            // creates a session that uses my Firefox profile.

            FirefoxProfileManager profileManager = new FirefoxProfileManager();
            FirefoxProfile profile = profileManager.GetProfile("Ryan");
            IWebDriver driver = new FirefoxDriver(profile);
            
            
            driver.Url = "http://www.google.com";
            

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            //Looks for the correct site.
            bool dubPresent;
            string episodeNumber;

            searchBox.SendKeys("animefreak.tv");


        

            searchBox.Submit();

            var searchButton = driver.FindElement(By.ClassName("lsb"));
            searchButton.Click();
            System.Threading.Thread.Sleep(1000);
            // Click on the first result for AnimeFreak.tv
            driver.FindElement(By.XPath("id('rso')/div/div[1]/div/h3/a")).Click();

            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.XPath("id('submenu')/ul/li[3]/a")).Click();
            System.Threading.Thread.Sleep(1000);

            //Selects "O" from the list
            driver.FindElement(By.XPath("id('primary')/div/div[3]/div[1]/div/div/span[20]/a")).Click();
            System.Threading.Thread.Sleep(1000);
            //Goes to OnePiece

             driver.FindElement(By.XPath(".//*[@id='primary']/div/div[3]/div[2]/table/tbody/tr[9]/td/a")).Click();
            System.Threading.Thread.Sleep(1000);

            //Goes to Episode 422
            //driver.FindElement(By.XPath("id('page')/div[5]/div[2]/div[2]/div/ul/li[418]/a")).Click();
            driver.FindElement(By.XPath("id('page')/div[5]/div[2]/div[2]/div/ul/li[1]/a")).Click();
            System.Threading.Thread.Sleep(1000);


            do
            {
                driver.FindElement(By.ClassName("page-next")).Click();
            } while (driver.FindElement(By.XPath("id('primary')/div/div[3]/div/a[2]")).Enabled);
            
             driver.Close();
            












        }
    }
}
