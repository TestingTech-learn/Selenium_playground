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
    public class Dropdownpage
    {

      public IWebDriver driver;
      public IWebElement Result5;
      public IWebElement Dropdown1;
      public IWebElement Dropdown2;
      public IWebElement Dropdown3;
      public IWebElement Dropdown4;
      public IWebElement Dropdown5;

      public IWebElement Dropdown6;




       public Dropdownpage(IWebDriver _driver)
       {
        driver=_driver;
        
        Result5=driver.FindElement(By.XPath("//h1[text()='Learn Listboxes']"));
        Dropdown1=driver.FindElement(By.CssSelector("[id='dropdown1']"));
        Dropdown2=driver.FindElement(By.CssSelector("[name='dropdown2']"));
        Dropdown3=driver.FindElement(By.CssSelector("[id='dropdown3']"));
        Dropdown4=driver.FindElement(By.CssSelector("[class='dropdown']"));
        Dropdown5=driver.FindElement(By.XPath("(//option[text()='Appium'])[5]"));
        Dropdown6=driver.FindElement(By.XPath("(//option[text()='Loadrunner'])[6]"));

       }

       public void DD1(){
        SelectElement select1=new SelectElement(Dropdown1);
        select1.SelectByIndex(1);
       }
       public void DD2()
       {
        SelectElement select2=new SelectElement(Dropdown2);
        select2.SelectByText("Selenium");
       }
       public void DD3(){
        SelectElement select3=new SelectElement(Dropdown3);
        select3.SelectByValue("3");
       }
       public void DD4(){
        SelectElement select4=new SelectElement(Dropdown4);
        var option = select4.Options;
        int count = option.Count;
        Console.WriteLine(count);
       }
       public void DD5(){
        Dropdown5.Click();
        
       }
       public void DD6(){
        Dropdown6.Click();
       }
















    }
}