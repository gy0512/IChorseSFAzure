using IChorse.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace IChorse.Pages
{
    class SFCompanyPage
    {
        // using current datetime or random number as dynamic parameter
        private static readonly string randDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
        private static readonly Random rd = new Random();
        public static string CurrentDateTime => randDateTime;
        public static int randNum = rd.Next(1, 999999);
        public static string firstname = "test";
        public static string lastname = "birds";
        public static string phone = "0210547001";


        public void CreateCompany(IWebDriver driver)
        {
            // create new company
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();
            Thread.Sleep(2000);//Wait not work

            // validate create new
            try
            {
                IWebElement Company = driver.FindElement(By.XPath("//*[@id=\"container\"]/h2"));
                Assert.That(Company.Text == "Company");
            }
            catch (Exception ex)
            {
                Assert.Fail($"{driver.FindElement(By.XPath("//*[@id=\"container\"]/h2")).Text} != Company", ex.Message);
            }
        }
    }
}
