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
using OpenQA.Selenium.Chrome;

namespace frameworkproject
{
    public class Autocomplete
    {

      public IWebDriver driver;
      public IWebElement Result20; 


      
      public Autocomplete(IWebDriver _driver)
       {
        driver=_driver;
        Result20=driver.FindElement(By.CssSelector("[class='wp-page-heading']"));
       }

       public void autocompletepage(){
        var Text = driver.FindElement(By.Id("tags"));
        Actions actions =new Actions(driver);
        actions.SendKeys(Text,"Cucum").SendKeys(Keys.ArrowDown).SendKeys(Keys.Enter).Perform();

       }
    }
}