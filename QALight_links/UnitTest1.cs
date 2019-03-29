using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Linq;

namespace Selenium
{

    public class UnitTest1
    {
        // Assert
        public IWebDriver driver;
        
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
            OldQALight oldQALightpage = new OldQALight(driver);
            

            // Assert
            Assert.True(oldQALightpage.links.Count() == 7, "Qty of links is not 7");

        }
    }
}
