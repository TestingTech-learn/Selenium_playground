using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace frameworkproject
{
    public class Homepage
    {
        public IWebDriver driver;
        public IWebElement Editoption;
        public IWebElement Buttonoption;
        public IWebElement LinkOption;
        public IWebElement imageoption;
        public IWebElement Dropdownoption;
        public IWebElement Radiobuttonoption;
        public IWebElement Checkboxoption;
        public IWebElement Tableoption;
        public IWebElement Alertoption;
        public IWebElement Frameoption;
        public IWebElement Windowhandlingoption;
        public IWebElement Mousehoveroption;
        public IWebElement Waitalertoption;
        public IWebElement Waittextoption;
        public IWebElement WaittoAppear;
        public IWebElement WaittoDisapper;
        public IWebElement ToolTip;
        public IWebElement upload;
        public IWebElement download;
        public IWebElement Autocomplete;
        public Homepage(IWebDriver _driver) //constructor
        {
            driver = _driver;
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // Element Section
            Thread.Sleep(5000);
            Editoption = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href=\"pages/Edit.html\"]")));
            Buttonoption =wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//h5[text()='BUTTON']")));
            LinkOption= wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/Link.html']")));
            imageoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/Image.html']")));
            Dropdownoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/Dropdown.html']")));
            Radiobuttonoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/radio.html']")));
            Checkboxoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/checkbox.html']")));
            Tableoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/table.html']")));
            Alertoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/Alert.html']")));
            Frameoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/frame.html']")));
            Windowhandlingoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/Window.html']")));
            Mousehoveroption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/mouseOver.html']")));
            Waitalertoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/alertappear.html']")));
            Waittextoption=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/TextChange.html']")));
            WaittoAppear=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/appear.html']")));
            WaittoDisapper=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/disapper.html']")));
            ToolTip=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/tooltip.html']")));
            upload=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/upload.html']")));
            download=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/download.html']")));
            Autocomplete=wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//a[@href='pages/autoComplete.html']")));
            Console.WriteLine(" open a home page");

        }

        //Action

        public void ClickEditPage()
        {
            Editoption.Click();
            Console.WriteLine("edit page clicked");
        }
        public void ClickButtonPage()
        {
            Buttonoption.Click();
            Console.WriteLine("button page clicked");
        }

        public void clickLinkPage(){
            LinkOption.Click();
            Console.WriteLine("link page clicked");

        }

        public void clickimagepage(){
            imageoption.Click();
            Console.WriteLine("image page clicked");
        }

        public void clickdropdownpage(){
               Dropdownoption.Click();
               Console.WriteLine("dropdown page clicked");
        }

        public void clickRadiobuttonpage(){
            Radiobuttonoption.Click();
            Console.WriteLine("Radio button page clicked");
        }

        public void clickcheckboxpage()
        {
            Checkboxoption.Click();
            Console.WriteLine("check box page clicked");
        }
        public void clickTablepage()
        {
            Tableoption.Click();
            Console.WriteLine("table page clicked");

        }
        public void ClickAlertpage()
        {
            Alertoption.Click();
            Console.WriteLine("alert page clicked");
        }
        public void clickframepage()
        {
            Frameoption.Click();
            Console.WriteLine("frame page clicked");
        }

        public void ClickWindowpage()
        {
            Windowhandlingoption.Click();
            Console.WriteLine("window handling page clicked");
        }
        
        public void clickmousehovepage(){
            Mousehoveroption.Click();
            Console.WriteLine("MouseHover page clicked");

        }
        public void Clickalertoptionpage()
        {
            Waitalertoption.Click();
            Console.WriteLine("wait for alert clicked");
            
        }

        public void cilckwaitalerttextpage(){
            Waittextoption.Click();
            Console.WriteLine("wait for text page clicked");
        }
        
        public void clickwaittoapperpage(){
            WaittoAppear.Click();
            
            Console.WriteLine("wait for appear page clicked");


        }

        public void clickDisapperpage(){
            WaittoDisapper.Click();
            Console.WriteLine("wait for disapper page clicked");
        }
        public void clicktooltippage()
        {
            ToolTip.Click();
            Console.WriteLine("Tool tip page clicked");   

        }

        public void clickuploadpage()
        {
            upload.Click();
            Console.WriteLine("upload page clicked");   
        }

        public void clickdownloadpage(){
            download.Click();
             Console.WriteLine("download page clicked");   


        }
        public void Clickautocompletepage(){
            Autocomplete.Click();
            Console.WriteLine("autocomplete page clicked");
        }

        


    





    }


    


    }

