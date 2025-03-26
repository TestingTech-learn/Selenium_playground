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
    public class Waitfordisappear
    {

      public IWebDriver driver;
      public IWebElement Result16; 


      
      public Waitfordisappear(IWebDriver _driver)
       {
        driver=_driver;
        Result16=driver.FindElement(By.CssSelector("[class='wp-heading']"));
       }

       public void beforedisappear()
       {
          WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
          var disappear =wait.Until(ExpectedConditions.InvisibilityOfElementLocated(By.Id("btn")));
          Console.WriteLine("i can able to see a button");
          var confirmationmessage=driver.FindElement(By.TagName("strong"));
          if(confirmationmessage.Displayed)
          {
            Console.WriteLine("Test Passed: Confirmation message is displayed.");
          }
          else{

          Console.WriteLine("Test Failed: Confirmation message is not displayed.");


          }

       }



    }
    }