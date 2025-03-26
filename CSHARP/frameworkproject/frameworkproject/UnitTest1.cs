using System.Net;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace frameworkproject
{
    [TestFixture]
    public class Tests
    {
        public static IWebDriver driver;
        public string siteurl = "https://manojkumar4636.github.io/Selenium_Practice_Hub/ ";
        public string Mailid = "abc@gamil.com";
        public string Text="chennai";
         private ExtentReports extent;
         private ExtentTest test;
        

        Basepage basepage = new Basepage();
        

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            
            driver = basepage.getdriver("chrome");

        var currentdate = DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt").Replace(':','-').Replace(' ','-');
        var currentpath=@"C:\Users\User\CSHARP\frameworkproject\frameworkproject\Reports\TestReport";
        var filename = $"{currentpath}ExtentSparkReport{currentdate}.html";
        var sparkReporter = new ExtentSparkReporter(filename);
        sparkReporter.Config.ReportName = "NUnit Test Execution Report";
        sparkReporter.Config.Theme = AventStack.ExtentReports.Reporter.Config.Theme.Dark;
        extent = new ExtentReports();
        extent.AttachReporter(sparkReporter);

        }

        [SetUp]
        public void Setup()
        {
            basepage.Goto(driver,siteurl);
            Console.WriteLine("opening a base page");
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

      // [Ignore("Ignoring this test case")]
        [Test,Order(1)]
        public void WorkWithEditFields()

        {
          
            Homepage homepage = new Homepage(driver);
            homepage.ClickEditPage();
            Editpage editpage = new Editpage(driver);
            editpage.EnterEmail(Mailid);
            editpage.AppendText(Text);
            editpage.appendPerform();
            editpage.GetdefaultText();
            editpage.cleartext();
            editpage.confirmDisable();
            Boolean a=Editpage.Result1.Displayed;
            Assert.True(a);
            Thread.Sleep(5000);
            basepage.screenshot("EditFields");
        }

     //  [Ignore("Ignoring this test case")]
        [Test,Order(2)]
        public void WorkWithButtons(){
            Homepage homepage=new Homepage(driver);
            homepage.ClickButtonPage();
            Buttonpage buttonpage=new Buttonpage(driver);
            buttonpage.ClickHomeButton();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            buttonpage.PositionButton();
            Thread.Sleep(5000);
            buttonpage.ColourButton();
            Thread.Sleep(5000);
            buttonpage.Sizebutton();
            Boolean b = buttonpage.Result2.Displayed;
            Assert.True(b);
            Thread.Sleep(5000);
            basepage.screenshot("buttons");
        }

        //[Ignore("Ignoring this test case")]
         [Test,Order(3)]
         public void Interactwithlinks(){
            Homepage homepage=new Homepage(driver);
            homepage.clickLinkPage();
            Thread.Sleep(2000);
            Hyperlinkpage HLP = new Hyperlinkpage(driver);
            HLP.Firstlink();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            HLP.SecondLink();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(2000);
            HLP.Thirdlink();
            Thread.Sleep(2000);
            HLP.Fouthlink();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            HLP.fifthlink();
            Thread.Sleep(2000);
            Boolean c = HLP.Result3.Displayed;
            Assert.True(c);
               Thread.Sleep(5000);
             basepage.screenshot("Links");
        }
      // [Ignore("Ignoring this test case")]
        [Test,Order(4)]
        public void workwithimage()
        {
            Homepage homepage=new Homepage(driver);
            homepage.clickimagepage();
            Imagepage imagepage = new Imagepage(driver);
            imagepage.FirstImage();
            Thread.Sleep(2000);
            driver.Navigate().Back();
            Thread.Sleep(3000);
            imagepage.secondImage();
            Thread.Sleep(2000);
            imagepage.thirdimage();
            Thread.Sleep(2000);
          //  Boolean d = imagepage.Result4.Displayed;
            //Assert.True(d);
            Thread.Sleep(5000);
             basepage.screenshot("Images");
        }
       
       // [Ignore("Ignoring this test case")]
        [Test,Order(5)]
        public void WorkWithDropdown(){
         Homepage homepage=new Homepage(driver);
         homepage.clickdropdownpage();
         Dropdownpage DD = new Dropdownpage(driver);
         DD.DD1();
         Thread.Sleep(1000);
         DD.DD2();
         Thread.Sleep(1000);
         DD.DD3();
         Thread.Sleep(1000);
         DD.DD4();
         Thread.Sleep(1000);
         DD.DD5();
         Thread.Sleep(1000);
         DD.DD6();
         Boolean d = DD.Result5.Displayed;
         Assert.True(d);
            Thread.Sleep(5000);
          basepage.screenshot("Dropdown");
                      
         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(6)]
         public void interactwithRadiobuttons()
         {
            Homepage homepage=new Homepage(driver);
            homepage.clickRadiobuttonpage();
            Radiobuttonpage RB= new Radiobuttonpage(driver);
            RB.Radiobutton1("yes");
            RB.Radiobutton2();
            RB.Radiobutton3("25");
            Boolean E = RB.Result6.Displayed;
            Assert.True(E);
             Thread.Sleep(5000);
            basepage.screenshot("RadioButtons");
         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(7)]
         public void interactwithcheckbox()
         {
            Homepage homepage =new Homepage(driver);
            homepage.clickcheckboxpage();
            Checkboxpage checkboxpage=new Checkboxpage(driver);
            checkboxpage.Checkbox1(["Java","VB"]);
            checkboxpage.Checkbox2();
            checkboxpage.Checkbox3("I am Selected",true);
            Boolean F = checkboxpage.Result7.Displayed;
            Assert.True(F);
               Thread.Sleep(5000);
             basepage.screenshot("checkbox");
         }
        //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(8)]
         public void interactwithtables()
         {
            Homepage homepage =new Homepage(driver);
            homepage.clickTablepage();
            Thread.Sleep(2000);
            Tablepage tablepage = new Tablepage(driver);
            tablepage.Getrows();
            Thread.Sleep(2000);
            tablepage.Getcolumns();
            Thread.Sleep(2000);
            tablepage.interactwithelements("Learn to interact with Elements","Progress");
            Thread.Sleep(2000);
            tablepage.checkthevitalbox();
            Boolean G =tablepage.Result8.Displayed;
            Assert.True(G);
               Thread.Sleep(5000);
             basepage.screenshot("Tables");

         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(9)]
         public void handleAlerts()
         {
            Homepage homepage =new Homepage(driver);
            homepage.ClickAlertpage();
            Thread.Sleep(2000);
            Alertpage alertpage = new Alertpage(driver);
            alertpage.Alert1();
            Thread.Sleep(2000);
            alertpage.Alert2();
            Thread.Sleep(2000);
            alertpage.Alert3();
            Thread.Sleep(2000);
            alertpage.Alert4();
            Thread.Sleep(2000);
            alertpage.sweetalert();   
            Boolean H =alertpage.Result9.Displayed;
            Assert.True(H);
               Thread.Sleep(5000);
             basepage.screenshot("Alerts");
         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(10)]
         public void InteractWithFrames()
         {
            Homepage homepage =new Homepage(driver);
            homepage.clickframepage();
            Framepage framepage = new Framepage(driver);
            Thread.Sleep(2000);
            framepage.insideframe();
            Thread.Sleep(2000);
            framepage.NestedFrame();
            Thread.Sleep(2000);
            framepage.numberoflinks();
            Boolean I = framepage.Result10.Displayed;
            Assert.True(I);
               Thread.Sleep(5000);
             basepage.screenshot("Frames");

         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(11)]
         public void Funwithwindows()
         {
            Homepage homepage =new Homepage(driver);
            homepage.ClickWindowpage();
            Windowpage windowpage = new Windowpage(driver);
            windowpage.Firstbutton();
            Thread.Sleep(3000);
            windowpage.secondbutton();
            Thread.Sleep(3000);
            windowpage.thirdbutton();
            Thread.Sleep(3000);
            windowpage.fourthbutton();
            Thread.Sleep(5000);
             Boolean J =windowpage.Result11.Displayed;
            Assert.True(J);
            Thread.Sleep(5000);
             basepage.screenshot("Window handling");

         }
        // [Ignore("IGNORE THE TEST CASE")]
        [Test,Order(12)]
        public void Mousehoveraction()
        {
            Homepage homepage =new Homepage(driver);
            homepage.clickmousehovepage();
            Mousehoverpage mousehoverpage = new Mousehoverpage(driver);
            mousehoverpage.printalllinks();
            Thread.Sleep(2000);
            mousehoverpage.handlealerts();
            Boolean K =mousehoverpage.Result12.Displayed;
            Assert.True(K);
            Thread.Sleep(5000);    
            basepage.screenshot("MouseHover");       
        }
        // [Ignore("IGNORE THE TEST CASE")]
        [Test,Order(13)]
        public void waitalertaction()
        {
            Homepage homepage =new Homepage(driver);
            homepage.Clickalertoptionpage();
            WaitAlerts waitAlerts=new WaitAlerts(driver);
            waitAlerts.ExplictWait();
            Boolean I =waitAlerts.Result13.Displayed;
            Assert.True(I);
            Thread.Sleep(5000);
             basepage.screenshot("waits");
        }
        // [Ignore("IGNORE THE TEST CASE")]
         [Test,Order(14)]
         public void textalertpage(){
            Homepage homepage =new Homepage(driver);
            homepage.cilckwaitalerttextpage();
            WaittextAlert waittextAlert=new WaittextAlert(driver);
            waittextAlert.waitforTextchange();
            waittextAlert.textalert();
            Boolean J = waittextAlert.Result14.Displayed;
            Assert.True(J);
            Thread.Sleep(5000);
            basepage.screenshot("Textalerts");
         }
         //[Ignore("IGNORE THE TEST CASE")]
         [Test,Order(15)]
         public void Disappearpage(){
            Homepage homepage=new Homepage(driver);
            homepage.clickwaittoapperpage();
            WaittoAppear WA = new WaittoAppear(driver);
            WA.Fivebutton();
            Thread.Sleep(1000);
            WA.disappearbutton();
            Boolean K = WA.Result15.Displayed;
            Assert.True(K);
            Thread.Sleep(5000);
            basepage.screenshot("Disappearpage");
         }
        // [Ignore("IGNORE THE TEST CASE")]
         [Test,Order(16)]
         public void dissappeardbutton(){
         Homepage homepage=new Homepage(driver);
         homepage.clickDisapperpage();
         Waitfordisappear waitfordisappear = new Waitfordisappear(driver);
         waitfordisappear.beforedisappear();
         Boolean L = waitfordisappear.Result16.Displayed;
         Assert.True(L);
         Thread.Sleep(5000);
         basepage.screenshot("Disappearbutton");

         }
        // [Ignore("IGNORE THE TEST CASE")]
          [Test,Order(17)]
          public void tooltippage()
          {
           Homepage homepage=new Homepage(driver);
           homepage.clicktooltippage();
           Tooltip tooltip = new Tooltip(driver);
           Boolean  M = tooltip.Result17.Displayed;
           Assert.True(M);
           Thread.Sleep(5000);
           basepage.screenshot("Tooltip");
          }
        //[Ignore("IGNORE THE TEST CASE")]
        [Test,Order(18)]
           public void uploadpage()
           {
            Homepage homepage=new Homepage(driver);
            homepage.clickuploadpage();
            Upload upload = new Upload(driver);
            upload.uploadFile();
            Boolean N = upload.Result18.Displayed;
            Assert.True(N);
            Thread.Sleep(5000);
            basepage.screenshot("Uploadpage");
           }
          // [Ignore("IGNORE THE TEST CASE")]
           [Test,Order(19)]
            public void downloadpage(){
            Homepage homepage=new Homepage(driver);
            homepage.clickdownloadpage();
            Download download=new Download(driver);
            download.downloadpage();
            // Boolean O =download.Result19.Displayed;
           // Assert.True(O);
            Thread.Sleep(5000);
            basepage.screenshot("Downloadpage");

            }
            [Test,Order(20)]
            public void Autocompletepage(){
            Homepage homepage=new Homepage(driver);
            homepage.Clickautocompletepage();
            Autocomplete autocomplete=new Autocomplete(driver);
            autocomplete.autocompletepage();
            Boolean P = autocomplete.Result20.Displayed;
            Assert.True(P);
            Thread.Sleep(5000);
            basepage.screenshot("Autocomplete");

            }
         


        [TearDown]
        public void TearDown()
        {
            var testStatus = TestContext.CurrentContext.Result.Outcome.Status;
            var message = TestContext.CurrentContext.Result.Message;

            if (testStatus == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                test.Fail("Test Failed: " + message);
            }
            else if (testStatus == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Pass("Test Passed Successfully");
            }

           
        }

         [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            extent.Flush();
            driver.Dispose();
        }








    }


}