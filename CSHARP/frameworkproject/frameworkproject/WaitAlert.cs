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
    public class WaitAlerts
    {

      public IWebDriver driver;
      public IWebElement Result13; 
      public IWebElement clickAlert;    
      public WaitAlerts(IWebDriver _driver)
       {
        driver=_driver;
        Result13=driver.FindElement(By.CssSelector("[class='wp-heading'] "));
       }

       public void ExplictWait()
       {
        clickAlert=driver.FindElement(By.Id("alert"));
        clickAlert.Click();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        wait.Until(ExpectedConditions.AlertIsPresent());
        IAlert alert = driver.SwitchTo().Alert();
        alert.Accept();
       }
    }
}
