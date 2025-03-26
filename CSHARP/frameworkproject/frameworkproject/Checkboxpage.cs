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
    public class Checkboxpage
    {

      public IWebDriver driver;
      public IWebElement Result7;
      

      
       public Checkboxpage(IWebDriver _driver)
       {
        driver=_driver;
        Result7=driver.FindElement(By.XPath("//h1[text()='Interact with Checkboxes']"));
       }

       public void Checkbox1(String[]inputs)
       {
        foreach (var item in inputs)
            {
               var box1 = driver.FindElement(By.XPath($"//*[@class='innerblock']//*[@class='example'][1]//div[text()='{item}']/input"));
               box1.Click();
            }
       }
       public void Checkbox2()
       {
        var box2 = driver.FindElement(By.XPath("//*[@class='innerblock']//*[@class='example'][2]//input"));
        bool status = box2.Selected;
        Console.WriteLine(status);
       }
       public void Checkbox3(String DeSelectOnlyChecked,bool selectThecheckbox)
       {
        var Box3 = driver.FindElement(By.XPath($"//*[@class='innerblock']//*[@class='example'][3]//div[text()='{DeSelectOnlyChecked}']//input"));
            bool status02 =  Box3.Selected;
            if (!status02 && selectThecheckbox)
            {
                Box3.Click();
            }

       }
       public void checkbox4()
       {
        var Box4 = driver.FindElements(By.XPath("//*[@class=\"innerblock\"]//*[@class=\"example\"][4]//div//input"));
           foreach (var item in Box4)
           {
               item.Click();
           }
       }


    }
}
 