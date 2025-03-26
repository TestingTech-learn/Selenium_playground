using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Net.Http;
using OpenQA.Selenium.Interactions;

namespace frameworkproject
{
    public class WaittextAlert
    {

      public IWebDriver driver;
      public IWebElement Result14; 
      public IWebElement buttonsI;
      
      public WaittextAlert(IWebDriver _driver)
       {
        driver=_driver;
        Result14=driver.FindElement(By.CssSelector("[class='wp-page-heading']"));
       }
       public void waitforTextchange()
       {
         buttonsI=driver.FindElement(By.Id("btn"));
         string ExpectedText = "Click ME!";
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
         bool istextchanged = wait.Until(drv => buttonsI.Text.Equals(ExpectedText));
         if(istextchanged)
         {
            Console.WriteLine("Button text has changed to: " + buttonsI.Text);
         }else
         {
            Console.WriteLine("Button text did not change within the timeout period.");

         }

       }
       public void textalert()
       {
            buttonsI=driver.FindElement(By.Id("btn"));
            buttonsI.Click();
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.AlertIsPresent());
            IAlert alerts = driver.SwitchTo().Alert();
            string alertText = alerts.Text;
            Console.WriteLine("Alert Text: " + alertText);
            string ExpectedText1 = "Click ME!";
            if (alertText == ExpectedText1)
                {
                    Console.WriteLine("Alert text verification passed.");
                }
                else
                {
                    Console.WriteLine("Alert text verification failed.");
                }
                alerts.Accept();
        


       }



    }
}
