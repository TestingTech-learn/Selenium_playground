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
    public class Tablepage
    {

      public IWebDriver driver;
      public IWebElement Result8;
      public IWebElement Table;
      

      
     public Tablepage(IWebDriver _driver)
       {
        driver=_driver;
        Result8=driver.FindElement(By.XPath("//h1[text()='Toy with Tables']"));
        Table=driver.FindElement(By.Id("table_id"));

       }

       public void Getrows()
       {
        var rows = Table.FindElements(By.TagName("tr"));
        int rowcount=rows.Count();
        Console.WriteLine("Number of rows: " + rowcount);
       }

       public void Getcolumns()
       {
        var columns=Table.FindElements(By.TagName("th"));
        int columncount=columns.Count();
        Console.WriteLine("Number of columns: " + columncount);
       }
       public void interactwithelements(string rowValue, string columnName)
       {
        int index = 0;
            var Elements = driver.FindElements(By.XPath("//tbody//tr[1]//th"));
            for (int i = 0; i < Elements.Count; i++)
            {
                if (Elements[i].Text == columnName)
                {
                    index = i;
                    break;
                }
            }
            var value = driver.FindElement(By.XPath($"//*[text()='{rowValue}']/parent::tr//td[{index+1}]")).Text;

       }
       public void checkthevitalbox()
       {
         var  progressElement = driver.FindElements(By.XPath("//td[2]"));
         List<int> progressValue = progressElement.Select(e =>Convert.ToInt32(e.Text.Replace("%",""))).ToList();
         int minprogressindex = progressValue.IndexOf(progressValue.Min());
         var checkbox= driver.FindElement(By.XPath($"//*[@id='table_id']/tbody/tr[{minprogressindex + 2}]/td[3]/input"));
         checkbox.Click();


    

       }



















       
      


       
       }
       
       }
