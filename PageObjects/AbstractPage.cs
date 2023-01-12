using EvrazTH.Support;

namespace EvrazTH.PageObjects
{
    public abstract class AbstractPage
    {
        protected IWebDriver _driver;
        public IWebElement ButtonCatalog => _driver.FindElement(By.XPath($"//button[@class='btn btn-primary header-main__catalog-btn d-none d-lg-flex'] "));

        public AbstractPage()
        {
            _driver = SingleWebDriver.GetInstance();
            _driver.Manage().Window.Maximize();
        }

        public abstract void OpenThisPage();

        public void ClickCatalog()
        {
            ButtonCatalog.Click();
        }
    }
}
