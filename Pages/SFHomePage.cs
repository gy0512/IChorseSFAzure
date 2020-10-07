﻿using IChorse.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace IChorse.Pages
{
    class SFHomePage
    {
        public void NavigateToTM(IWebDriver driver)
        {
            // click on Administration
            driver.FindElement(By.XPath("/ html/body/div[3]/div/div/ul/li[5]/a")).Click();

            // click on Time & Materials
            driver.FindElement(By.XPath("/ html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a")).Click();

            // validate Time & Materials
            try
            {
                IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
                Assert.That(createNew.Text == "Create New");
            }
            catch (Exception ex)
            {
                Assert.Fail($"{driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a")).Text} != Create New", ex.Message);
            }
        }

        public void NavigateToCompany(IWebDriver driver)
        {
            // click on Administration
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a")).Click();

            // click on Companies
            driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[6]/a")).Click();
            Wait.WaitForElement(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[6]/a", 3);

            // validate Companies
            try
            {
                IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[2]/div/table/thead/tr/th[1]/a"));
                Assert.That(createNew.Text == "Name");
            }
            catch (Exception ex)
            {
                Assert.Fail($"{driver.FindElement(By.XPath("//*[@id=\"companiesGrid\"]/div[2]/div/table/thead/tr/th[1]/a")).Text} != Name", ex.Message);
            }
        }
    }
}
