using IChorse.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace IChorse.Pages
{
    class SFTMPage
    {
        public string CreateRandomPrice()
        {
            var r = new Random();
            return $"{r.Next(1, 99)}";
        }

        public string CreateRandomCode()
        {
            var dt = DateTime.Now.ToString("yyyyMMddHHmmss");
            return dt;
        }

        public void CreateTM(IWebDriver driver)
        {
            // click on createnew
            driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Click();

            // validate create new
            try
            {
                IWebElement timeMaterials = driver.FindElement(By.XPath("//*[@id=\"container\"]/h2"));
                Assert.That(timeMaterials.Text == "Time and Materials");
            }
            catch (Exception ex)
            {
                Assert.Fail($"{driver.FindElement(By.XPath("//*[@id=\"container\"]/h2")).Text} != Time and Materials", ex.Message);
            }
        }
    }
}