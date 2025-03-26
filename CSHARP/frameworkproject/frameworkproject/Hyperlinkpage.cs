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
    public class Hyperlinkpage
    {
      public IWebDriver driver;
      public IWebElement Result3;
      public IWebElement FirstHomePage;
      public IWebElement  withoutclick;
      public IWebElement BrokenLink;
      public IWebElement secondhomepage;
      public IList<IWebElement> Numberoflinks;

      
      
      public Hyperlinkpage(IWebDriver _driver){

        driver=_driver;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        Result3=driver.FindElement(By.XPath("//h1[text()='Play with HyperLinks']"));
        FirstHomePage=wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Go to Home Page")));
        withoutclick= wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Find where am supposed to go without clicking me?")));
        BrokenLink=wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Verify am I broken?")));
        secondhomepage=wait.Until(ExpectedConditions.ElementToBeClickable(By.LinkText("Go to Home Page")));
        Numberoflinks=driver.FindElements(By.TagName("a"));

      }

      public void Firstlink()
      {
        FirstHomePage.Click();
        String URL1 = driver.Url;
        Console.WriteLine("currentURL is  "+URL1);

      }
      public void SecondLink(){
        Thread.Sleep(1000);
        withoutclick.Click();
        String URL2 = driver.Url;
        Console.WriteLine("currentURL is  "+URL2);
      }

      public  void Thirdlink()
      {
        Actions action = new Actions(driver);
        action.MoveToElement(BrokenLink).Perform();
        Thread.Sleep(1000);
        String verifyUrl= BrokenLink.GetAttribute("href");
        if(!String.IsNullOrEmpty(verifyUrl)){
            try{
                using(HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response =  client.GetAsync(verifyUrl).Result;
                    int responseCode = (int)response.StatusCode;
                    if(responseCode>=400){
                        Console.WriteLine("Broken link: " + verifyUrl + " - Response code: " + responseCode);
                    }else{
                        Console.WriteLine("Valid link: " + verifyUrl + " - Response code: " + responseCode);
                    }
                }               
                }
                catch(Exception e){
                  Console.WriteLine("Error checking link: " +verifyUrl + " - Exception: " + e.Message);
                }

                }

            }
            public void Fouthlink()
            {
                secondhomepage.Click();
                String URL3 = driver.Url;
              Console.WriteLine("currentURL is  "+URL3);

            }

            public void fifthlink()
            {
               var links= Numberoflinks.Count();
                Console.WriteLine("Numberoflinks in hyperlink page is " + links);
                
            }




        }
      }






 