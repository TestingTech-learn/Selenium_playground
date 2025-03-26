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
    public class Tooltip
    {

      public IWebDriver driver;
      public IWebElement Result17; 


      
      public Tooltip(IWebDriver _driver)
       {
        driver=_driver;
        Result17=driver.FindElement(By.CssSelector("[class='wp-heading']"));
       }

       public void InsideTooltip()
       {
        var hover=driver.FindElement(By.TagName("input"));
        Actions actions =new Actions(driver);
        actions.MoveToElement(hover).Click().Perform();
       }

    }
}