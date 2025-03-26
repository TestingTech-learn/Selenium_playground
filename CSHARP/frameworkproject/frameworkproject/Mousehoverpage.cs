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
    public class Mousehoverpage
    {

      public IWebDriver driver;
      public IWebElement Result12;
      public IWebElement Testleafbutton;
      public IList<IWebElement>alllinks;
      public IWebElement clickbutton;
      
      

      
     public Mousehoverpage(IWebDriver _driver)
       {
        driver=_driver;
        Result12=driver.FindElement(By.XPath("//h1[text()='Mouse Hover using Actions']"));
       }

       public void printalllinks()
       {

        Testleafbutton=driver.FindElement(By.XPath("//a[text()='TestLeaf Courses']"));
        Actions actions =new Actions(driver);
        actions.MoveToElement(Testleafbutton).Perform();
        Thread.Sleep(2000);
        alllinks=driver.FindElements(By.XPath("//a[text()='TestLeaf Courses']/following-sibling::ul/li/a"));
        
        foreach (var item in alllinks)
        {
            Console.WriteLine(item.Text);
        }
       }
       public void handlealerts()
       {
        Testleafbutton=driver.FindElement(By.XPath("//a[text()='TestLeaf Courses']"));
        Actions actions =new Actions(driver);
        actions.MoveToElement(Testleafbutton).Perform();
        Thread.Sleep(2000);
        clickbutton=driver.FindElement(By.XPath("//a[text()='WebServices']"));
        clickbutton.Click();
        IAlert alert = driver.SwitchTo().Alert();
        alert.Accept();

       }
       
    }
}