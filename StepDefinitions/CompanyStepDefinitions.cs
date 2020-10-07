using IChorse.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;


namespace IChorse.StepDefinitions
{
    [Binding, Scope(Feature = "Company")]//[Binding]

    public sealed class CompanyStepDefinitions
    {
        IWebDriver driver;

        //[BeforeScenario]
        //public void LoginToTurnUp()
        //{
        //    // define webdriver
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

        //[Given(@"I login to the TurnUp")]
        //public void GivenILoginToTheTurnUp()
        //{
        //    // define webdriver
        //    driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)); //driver = new ChromeDriver();

        //    // Object init and define for login page
        //    SFLoginPage loginObj = new SFLoginPage();
        //    loginObj.LoginSteps(driver);

        //}
        [Given(@"I login to the TurnUp for Company")]
        public void GivenILoginToTheTurnUpForCompany()
        {
            // define webdriver
            var option = new ChromeOptions();
            option.AddArgument("--window-size=1920,1080");
            option.AddArgument("--headless");
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), option);
            //driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Object init and define for login page
            SFLoginPage loginObj = new SFLoginPage();
            loginObj.LoginSteps(driver);
        }

        //Cretate New Company Start
        [Given(@"I navigate to the Company")]
        public void GivenINavigateToTheCompany()
        {
            var homePage = new SFHomePage();
            homePage.NavigateToCompany(driver);
        }

        [Given(@"I click the create new button for Company")]
        public void GivenIClickTheCreateNewButtonForCompany()
        {
            var companyPage = new SFCompanyPage();
            companyPage.CreateCompany(driver);
        }
    }
}
