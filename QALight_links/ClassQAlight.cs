using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Selenium
{
    public class oldQALight
    {
        public IWebDriver driver;

        public oldQALight(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "footer_social")]
        public IWebElement links;

    }


}
