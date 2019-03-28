using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{

    public class UnitTest1
    {
        // Assert
        public IWebDriver driver;
        int kolvoLinks = 7;

        [SetUp]
        public void SetUp()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://old.qalight.com.ua/zapisatsya-na-kursy");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
        [Category("CountLinks")]
        [Test]
        public void countLinks()
        {
            // Act
            oldQALight oldQALightpage = new oldQALight(driver);
            oldQALightpage.links.FindElements(By.).Count();

            // oldQALightpage.searchButton.Click();

            // Assert
            Assert.True(kolvoLinks == 7);

            //Assert.True(IsElementPresent(oldQALightpage.seleniumClass),
            //    $"seleniumClass {nameof(oldQALightpage.seleniumClass)}' is not present on the page.");

           
            void SetImplicitTimeOut(IWebDriver driver, int timeout)
            {
                driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(timeout);
            }
        }
    }
}
