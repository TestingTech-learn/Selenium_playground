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
using OpenQA.Selenium.Chrome;

namespace frameworkproject
{
    public class Download
    {

      public IWebDriver driver;
      public IWebElement Result19; 


      
      public Download(IWebDriver _driver)
       {
        driver=_driver;
        Result19=driver.FindElement(By.CssSelector("[class='wp-page-heading']"));
       }

       public void downloadpage()
       {
        string downloadpath=@"C:\Users\User\CSHARP\frameworkproject\frameworkproject\download";
        ChromeOptions options = new ChromeOptions();
        options.AddUserProfilePreference("download.default_directory",downloadpath);
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(25));
        var downloadlink1 = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[href='../testleaf.xlsx']")));
        downloadlink1.Click();
        Thread.Sleep(2000);
        var filepath1 = Path.Combine(downloadpath,"downladedfile.xlsx");
        if(File.Exists(filepath1)){
          Console.WriteLine("download successful");
        }
        else{
          Console.WriteLine("no excel file to download");
        }
        driver.Navigate().Back();
         Thread.Sleep(2000);
        var downloadlink2=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[href='../testleaf.pdf']")));
        downloadlink2.Click();
         Thread.Sleep(2000);
        var filepath2 = Path.Combine(downloadpath,"downladedfile.pdf");
        if(File.Exists(filepath2)){
          Console.WriteLine("download successful");
        }
        else{
          Console.WriteLine("no pdf file to download");
        }
         driver.Navigate().Back();
         Thread.Sleep(2000);
        var downloadlink3=wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("[href='../testleaf.txt']")));
        downloadlink3.Click();
         Thread.Sleep(2000);
        var filepath3 = Path.Combine(downloadpath,"downladedfile.pdf");
        if(File.Exists(filepath3)){
          Console.WriteLine("download successful");
        }
        else{
          Console.WriteLine("no text file to download");
        }
        driver.Navigate().Back();
         Thread.Sleep(2000);
  

        
       }

    }
}
