using System;
using System.Collections.Generic;
using System.Linq;
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
//            String AdBlockerFilePath = "C:'\'Users'\'ryaher'\'AppData'\'Roaming'\'Mozilla'\'Firefox'\'Profiles'\'mzzqocaz.default'\'adblockplus'\'elemhide.css";
//            FirefoxProfile profile = new FirefoxProfile();       
//            profile.AddExtension(AdBlockerFilePath);
            //addExtension(new File(firebugFilePath));
            
            

            FirefoxProfileManager profileManager = new FirefoxProfileManager();
            FirefoxProfile profile = profileManager.GetProfile("Ryan");
            IWebDriver driver = new FirefoxDriver(profile);
            
            driver.Url = "http://www.google.com";
            

            var searchBox = driver.FindElement(By.Name("q"));
            //Looks for the correct site.

            searchBox.SendKeys("animefreak.tv");


        

            searchBox.Submit();

            var searchButton = driver.FindElement(By.ClassName("lsb"));
            searchButton.Click();

            

            

            


        }
    }
}
