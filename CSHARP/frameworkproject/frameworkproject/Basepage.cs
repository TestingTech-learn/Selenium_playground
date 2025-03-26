using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frameworkproject
{
    public class Basepage
    {
        // driver initiate and return
        public IWebDriver driver;//declaration
        public IWebDriver getdriver(string Browsername)
        {
            if (Browsername.ToLower() == "chrome")
            {
                driver = new ChromeDriver(); //initialize
            }
            driver.Manage().Window.Size = new System.Drawing.Size(1920,1080);
            return driver;
        }

        public void Goto(IWebDriver driver, string url)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Navigate().GoToUrl(url);
            //driver.Manage().Window.Maximize();
        }

        public void screenshot(String Filename)
        {
            string screenshotfolder = @"C:\Users\User\CSHARP\frameworkproject\frameworkproject\Screenshot";
            ITakesScreenshot screenshotDriver = (ITakesScreenshot)driver;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile($"{screenshotfolder}\\{Filename}.png");

        }
    }
}
