using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace frameworkproject
{
    public class Editpage
    {
        public IWebDriver driver;
        public IWebElement EmailTextBox;
        public IWebElement appendTextBox;
        public IWebElement GetdefaulttextBox;
        public IWebElement CleartextBox;
        public IWebElement confirmdiablebox;
        public static IWebElement Result1 ;

        public Editpage(IWebDriver _driver) //constructor
        {
            driver = _driver;

            // locator section
            Result1=driver.FindElement(By.XPath("//h1[text()='Work with Edit Fields	']"));
            EmailTextBox = driver.FindElement(By.Id("email"));
            appendTextBox = driver.FindElement(By.CssSelector("[value='Append ']"));
            GetdefaulttextBox = driver.FindElement(By.CssSelector("[value='TestLeaf']"));
            CleartextBox = driver.FindElement(By.CssSelector("[value='Clear me!!']"));
            confirmdiablebox = driver.FindElement(By.XPath("//*[text()='Confirm that edit field is disabled']/parent::div/input"));

        }

        //Action

        public void EnterEmail(string Emailaddress)
        {
            EmailTextBox.SendKeys(Emailaddress);
        }
        public void AppendText(string Text)
        {
            appendTextBox.SendKeys(Text);
        }
        public void appendPerform()
        {
            appendTextBox.SendKeys(Keys.Tab);
        }
        public void GetdefaultText()
        {
            var text =GetdefaulttextBox.GetAttribute("value");   
            Console.WriteLine(text);
        }
        public void cleartext()
        {
            CleartextBox.Clear();
        }
        public bool confirmDisable()
        {
           String status= confirmdiablebox.GetDomAttribute("disabled");
            return status == "true" ? true : false;

        }
    }
}
