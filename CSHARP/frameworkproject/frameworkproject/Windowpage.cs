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
    public class Windowpage
    {

      public IWebDriver driver;
      public IWebElement Result11;
      public IWebElement button1;
      public IWebElement button2;
      public IWebElement button3;
      public IWebElement button4;
      
     public Windowpage(IWebDriver _driver)
       {
        driver=_driver;
        Result11=driver.FindElement(By.XPath("//h1[text()='Handle with Windows']"));
       }

       public void Firstbutton()
       {
        var oldwindow = driver.CurrentWindowHandle;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        button1= wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("home")));
        button1.Click();
        Console.WriteLine("first button clicked");
        var windows = driver.WindowHandles;
        driver.SwitchTo().Window(windows[1]);
        Console.WriteLine("Switched to new window");
        var title = driver.Title;
        driver.FindElement(By.CssSelector("[href=\"pages/Edit.html\"]")).Click();
        Console.WriteLine("New window edit page clicked");
        driver.Close();
        driver.SwitchTo().Window(oldwindow);
       }
       public void secondbutton()

       {
           
         var oldwindow1 = driver.CurrentWindowHandle;
         WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
         button2= wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[text()='Open Multiple Windows']")));
         button2.Click();
         Console.WriteLine("Second button clicked");
         var numberofwindows= driver.CurrentWindowHandle.Count();
         Console.WriteLine("number of windows opened ; "+numberofwindows);
        
       }
       public void thirdbutton(){

        var oldwindow2= driver.CurrentWindowHandle;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        button3=wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("color")));
        button3.Click();
        Console.WriteLine("third button clicked");
        var windows2 = driver.WindowHandles;
        foreach (var window in windows2)
        {
            if (!window.Equals(oldwindow2)){
                driver.SwitchTo().Window(window);
                driver.Close();
            }
            
        }
        driver.SwitchTo().Window(oldwindow2);
       }

       public void fourthbutton()
       {
         var oldwindow3= driver.CurrentWindowHandle;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(50));
        button4=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//button[@id='color'][@style='background-color:lightblue']")));
        button4.Click();
        Console.WriteLine("fourth button clicked");
        var window3= driver.WindowHandles;
        foreach (var window in window3)
        {
            if(!window.Equals(oldwindow3)){
                driver.SwitchTo().Window(window);
                driver.Close();
                
            }
            driver.SwitchTo().Window(oldwindow3);
        }

       }




    }
}
