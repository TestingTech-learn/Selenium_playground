using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace frameworkproject
{
    public class Buttonpage
    {
      public IWebDriver driver;
      public IWebElement Result2;
      public IWebElement clickbutton;
      public IWebElement Getposition;
      public IWebElement GetColour;
      public IWebElement GetSize;

      public Buttonpage(IWebDriver _driver)
      {
        driver = _driver;
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        Result2=driver.FindElement(By.XPath("//h1[text()='Bond with Buttons']"));
        clickbutton=driver.FindElement(By.CssSelector("[id='home']"));
        Getposition=wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("position")));
        GetColour=wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("color")));
        GetSize=driver.FindElement(By.CssSelector("[id='size']"));
      }

      public void ClickHomeButton(){
        clickbutton.Click();
        string URL1 = driver.Url;
        Console.WriteLine("currentURL is  "+URL1);
      }
      public void PositionButton(){
        Point coordinates= Getposition.Location;
        int cordinatex= coordinates.X;
        int cordinatey=coordinates.Y;
        Console.WriteLine($"X axis : {cordinatex},Y axis : {cordinatey}");
      }

      public void ColourButton(){

        string Backgroundcolor= GetColour.GetCssValue("background-color");
        string  Textcolour= GetColour.GetCssValue("color");
        Console.WriteLine("background colour is  "+Backgroundcolor);
        Console.WriteLine("text colour is  "+Textcolour);
      }

      public void Sizebutton(){

        Size sizes=GetSize.Size;
        int height=sizes.Height;
        int width=sizes.Width;
        Console.WriteLine("button height is "+height);
        Console.WriteLine("button width is  "+width);


      }


    }
}
