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
    public class Alertpage
    {

      public IWebDriver driver;
      public IWebElement Result9;
      public IWebElement Alertbox;
      public IWebElement ConfimBox;
      public IWebElement PromptBox;
      public IWebElement LineBreaks;
      public IWebElement SweetAlert;
      
      

      
     public Alertpage(IWebDriver _driver)
       {
        driver=_driver;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        Result9=driver.FindElement(By.XPath("//h1[text()='Handle Alerts']"));
        Alertbox=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[onclick='normalAlert()']")));
        ConfimBox=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[onclick='confirmAlert()']")));
        PromptBox=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[onclick='confirmPrompt()']")));
        LineBreaks=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[onclick='lineBreaks()']")));
        SweetAlert=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[onclick='sweetalert()']")));
        

       }

       public void Alert1()
       {
        Alertbox.Click();
        IAlert alert = driver.SwitchTo().Alert();
        Console.WriteLine(alert.Text);
        alert.Accept(); 
        
       }
       public void Alert2()
       {
        ConfimBox.Click();
        IAlert alert2 = driver.SwitchTo().Alert();
        Console.WriteLine(alert2.Text);
        alert2.Accept(); 
        var result = driver.FindElement(By.Id("result"));
        Console.WriteLine(result.Text);

       }
       public void Alert3(){
        PromptBox.Click();
        IAlert alert3 = driver.SwitchTo().Alert();
        alert3.Accept(); 
        var result1 = driver.FindElement(By.Id("result1"));
        Console.WriteLine(result1.Text);
       }

       public void Alert4()
       {
        LineBreaks.Click();
        IAlert alert4 = driver.SwitchTo().Alert(); 
        Console.WriteLine(alert4.Text);
        alert4.Accept(); 
       

       }
       public void sweetalert(){
        SweetAlert.Click();
       }


    }
    
}
