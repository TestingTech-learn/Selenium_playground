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
    public class Framepage
    {

      public IWebDriver driver;
      public IWebElement Result10;
      public IWebElement Frame1;
      public IWebElement Frame2;
      public IList<IWebElement> numOfLinks;
      
     public Framepage(IWebDriver _driver)
       {
        driver=_driver;
        Result10=driver.FindElement(By.XPath("//h1[text()='Fun with frames']"));
        
       }
       public void insideframe()
       {
       Console.WriteLine("Before to frames");
       driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@src='default.html']")));
       Console.WriteLine("switched to frames");
       WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
       Frame1=wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Click")));
       Frame1.Click();
        String gettext = Frame1.Text;
        Console.WriteLine(gettext);
        driver.SwitchTo().DefaultContent();
       }
       public void NestedFrame()
       {
        Console.WriteLine("Before to frames");
        driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@src='page.html']")));
        Thread.Sleep(2000);
        driver.SwitchTo().Frame(driver.FindElement(By.XPath("//iframe[@src='nested.html']")));
         Console.WriteLine("switched to frames");
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        Frame2=wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("Click1")));
        Frame2.Click();
        String Gettext1=Frame2.Text;
        Console.WriteLine(Gettext1);
        driver.SwitchTo().DefaultContent();
       }
       public void  numberoflinks()
       {
        numOfLinks=driver.FindElements(By.TagName("iframe"));
        int size = numOfLinks.Count();
        Console.WriteLine(size);

       }
    }
}
