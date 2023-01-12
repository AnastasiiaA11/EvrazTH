namespace EvrazTH.PageObjects
{
    public  class CatalogPage:AbstractPage
    {
        public const string PageUrl = $"{Urls.Host}";
        public IWebElement ButtonWireOk=> _driver.FindElement(By.XPath("/html/body/header/div[3]/div/div/ul/li[3]/ul/li/a"));
        public IWebElement ButtonHotRolledSheet => _driver.FindElement(By.XPath("//*[@id=\"dropdown-menu-main-list\"]/li[2]/ul/li[1]/a"));
        public IWebElement ButtonInBasketButton => _driver.FindElement(By.XPath("/html/body/div[3]/main/div[3]/div[1]/div[2]/table/tbody/tr/td[4]/span/span[2]"));
        public IWebElement ButtonGoToBasket => _driver.FindElement(By.XPath("//*[@class='btn btn-primary add-to-backet-button']"));
        //public IWebElement ButtonBasket=> _driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div[2]/div/div[2]/div/div/div/div[1]/div[2]/div[1]/div[2]/div[4]/button/span[2]"));
        public CatalogPage()
        {

        }
        public override void OpenThisPage()
        {
            _driver.Navigate().GoToUrl(PageUrl);
        }

        public void ClickWireOkButton()
        {
            ButtonWireOk.Click();
        }

        public void ClickHotRolledSheetButton()
        {
            ButtonHotRolledSheet.Click();
        }

        public void ClickInBasketButton()
        {
            ButtonInBasketButton.Click();
        }

        public void ClickGoToBasket()
        {
            WebDriverWait webDriverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            webDriverWait.Until(ExpectedConditions.ElementExists(By.XPath($"//button[@id='bx_117848907_4475281_add_basket_link']"))).Click();
        }


        //public void ClickBasket()
        //{
        //    ButtonBasket.Click();
        //}
    }
}
