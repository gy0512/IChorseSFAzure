using IChorse.Helpers;
using IChorse.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;


namespace IChorse.StepDefinitions
{
    [Binding, Scope(Feature = "TM")]//[Binding]
    public sealed class TMStepDefinitions
    {
        static void Main(string[] args)
        {

        }
        IWebDriver driver;
        private Context _context;

        public TMStepDefinitions(Context context)
        {
            //_context = context;
            _context = new Context();
        }

        //[BeforeScenario]
        //public void LoginToTurnUp()
        //{
        //    // define webdriver
        //    //var option = new ChromeOptions();
        //    //option.AddArgument("no-sandbox");
        //    //option.AddArgument("--start-maximized");
        //    //option.AddArgument("--disable-gpu");
        //    //option.AddArgument("--disable-extensions");
        //    //option.AddArgument("--window-size=1920,1080");
        //    //option.AddArgument("--headless");
        //    //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), option);//driver = new ChromeDriver(option)
        //    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); //driver = new ChromeDriver();

        //    // Object init and define for login page
        //    SFLoginPage loginObj = new SFLoginPage();
        //    loginObj.LoginSteps(driver);
        //}

        [AfterScenario]
        public void Dispose()
        {
            driver.Dispose();// close the window and release memory
        }

        [Given(@"I login to the TurnUp")]
        public void GivenILoginToTheTurnUp()
        {
            // define webdriver
            var option = new ChromeOptions();
            option.AddArgument("--window-size=1920,1080");
            option.AddArgument("--headless");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), option);
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); //driver = new ChromeDriver();

            // Object init and define for login page
            SFLoginPage loginObj = new SFLoginPage();
            loginObj.LoginSteps(driver);
        }

        //Cretate New TM Start
        [Given(@"I navigate to the TM")]
        public void GivenINavigateToTheTM()
        {
            var homePage = new SFHomePage();
            homePage.NavigateToTM(driver);
        }


        [Given(@"I click the create new button")]
        public void GivenIClickTheCreateNewButton()
        {
            var tmPage = new SFTMPage();
            tmPage.CreateTM(driver);
        }


        [When(@"I create entries using code: '(.*)' and price: '(.*)'")]
        public void WhenICreateEntriesUsingCodeAndPrice(string code, string price)
        {
            var tmPage = new SFTMPage();
            var randNum = tmPage.CreateRandomPrice();
            var currentdt = tmPage.CreateRandomCode();
            _context.price = randNum;
            _context.code = currentdt;
            //tmPage.CreateTMWithValues(driver, _context.code, _context.price);
        }

        [Then(@"I am able to verify with code: '(.*)'")]
        public void ThenIAmAbleToVerifyWithCode(string code)
        {

        }
    }
}
