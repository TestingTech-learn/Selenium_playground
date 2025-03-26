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
    public class WaittoAppear
    {

      public IWebDriver driver;
      public IWebElement Result15; 
      public IWebElement disappear;
      
      
      public WaittoAppear(IWebDriver _driver)
       {
        driver=_driver;
        Result15=driver.FindElement(By.CssSelector("[class='wp-heading']"));
       }

       public void Fivebutton()
       {  
          
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

          var displaybutton =wait.Until(ExpectedConditions.ElementIsVisible(By.Id("btn")));
          var allButtons= driver.FindElements(By.TagName("button"));
           

          foreach (var item in allButtons)
          {
            Console.WriteLine(item.Text);
          }
       }

       public void disappearbutton(){
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        disappear=wait.Until(ExpectedConditions.ElementIsVisible(By.Id("btn")));
        Console.WriteLine(disappear.Text);
       }
    }
}

     