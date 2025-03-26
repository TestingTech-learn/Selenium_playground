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
    public class Radiobuttonpage
    {

      public IWebDriver driver;
      public IWebElement Result6;
      

      
       public Radiobuttonpage(IWebDriver _driver)
       {
        driver=_driver;
        Result6=driver.FindElement(By.XPath("//h1[text()='Play with Radio Buttons']"));
       
       }

       public void Radiobutton1(string EnjoyOption)
       {
        var YesOrNoButton="[type='radio'][id='"+ EnjoyOption.Trim().ToLower() + "']";  
        var Radiobuttons=driver.FindElement(By.CssSelector(YesOrNoButton));
        Radiobuttons.Click();
        
       }

       public void Radiobutton2()
       {
        var defaultCheckElement = driver.FindElement(By.XPath("//*[@type='radio'and @name='news' and @checked]/parent::label        "));
       string selectedcheckbox= defaultCheckElement.Text;
       Console.WriteLine(selectedcheckbox);
       }

       public void Radiobutton3(String ageGrpOption)
       {
        var ageOption = "";
            switch (ageGrpOption)
            {
                case "1 - 20 years":
                    ageOption = "0";
                    break;

                case "21 - 40 years":
                    ageOption = "1";
                    break;

                case "Above 40 years":
                    ageOption = "2";
                    break;
                default:
                    break;
            }

        var AgeElement = driver.FindElements(By.CssSelector($"[type='radio'][name='age'][value='{ageOption}']"));
        
        foreach (var item in AgeElement)
            {
                if (!item.Selected)
                {
                    item.Click();
                }
       }
    }
    }
}