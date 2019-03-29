using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Selenium
{
    public class OldQALight
    {
        public IWebDriver driver;

        public OldQALight(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"footer_social\"]/ul/li")]
        public IList <IWebElement> links;

    }


}
