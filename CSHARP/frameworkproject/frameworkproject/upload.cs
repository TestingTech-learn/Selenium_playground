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
    public class Upload
    {

      public IWebDriver driver;
      public IWebElement Result18; 


      
      public Upload(IWebDriver _driver)
       {
        driver=_driver;
        Result18=driver.FindElement(By.CssSelector("[class='wp-heading']"));
       }

       public void uploadFile()
       {
         var filepath ="c:\\Users\\User\\Desktop\\Programs\\1.PALINDROME.txt";
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
         var upload = driver.FindElement(By.TagName("input"));
         upload.SendKeys(filepath);
         Thread.Sleep(5000);  
       
    }
}

}