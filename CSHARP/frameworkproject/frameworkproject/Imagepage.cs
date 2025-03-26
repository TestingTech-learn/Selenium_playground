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
    public class Imagepage
    {

      public IWebDriver driver;
      public IWebElement Result4;
      public IWebElement Firstimage;
      public IWebElement Brokenimage; 
      public IWebElement  Actionimage;
    

      public Imagepage(IWebDriver _driver)
      {

        driver=_driver;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        Result4= wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h1[text()='Interact with Images	']")));
        Firstimage=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("img[src='../images/home.png']")));
        Brokenimage=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("(//img)[3]")));
        Actionimage=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("img[src='../images/keyboard.png']")));
      }

      public void FirstImage(){
        Firstimage.Click();
        String URL1 = driver.Url;
        Console.WriteLine("currentURL is  "+URL1);
      }

      public void secondImage(){
      Thread.Sleep(1000);
      String imageurl = Brokenimage.GetAttribute("src");
      bool isimagebroken=(bool) ((IJavaScriptExecutor) driver).ExecuteScript("return arguments[0].naturalWidth === 0;",Brokenimage);
      if(isimagebroken) {
	    	  Console.WriteLine("The Image is broken::: "+imageurl);
	      }else {
	    	  Console.WriteLine("The Image is Displayed correctly:::"+imageurl);
	      }

         }

         public void thirdimage(){
          Actions action =new Actions(driver);
          action.MoveToElement(Actionimage).Click().Build().Perform();
          String URL2 = driver.Url;
         Console.WriteLine("currentURL is  "+URL2);
         }


    }
}