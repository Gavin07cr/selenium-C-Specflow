using DocumentFormat.OpenXml.Bibliography;
using FluentAssertions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using Xunit;

namespace SpecFlow.Selenium.PageObjects
{
    public abstract class PageObject
    {
        private readonly IWebDriver _driver;

        public PageObject(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
            System.Threading.Thread.Sleep(2000);
            IWebElement firstCheckBox;
            if (url.Contains("google"))
                firstCheckBox = _driver.FindElement(OpenQA.Selenium.By.Id("L2AGLb"));
            else
                firstCheckBox = _driver.FindElement(By.ClassName(" css-47sehv"));
            firstCheckBox.Click();
        }

        public void AssertTitle(string title)
        {
            string pageTitle = _driver.Title;
            pageTitle.Should().Be(title);
        }
    }
}