using EvrazTH.PageObjects;

namespace EvrazTH.StepDefinitions
{
    [Binding]
    public class TestcaseoneStepDefinitions
    {
        
        [Given(@"Open site evraz https://evraz.market/")]
        public void GivenOpenSiteEvrazHttpsEvraz_Market()
        {
            var driver = SingleWebDriver.GetInstance();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(Urls.Host);
        }

        [When(@"Open catalog page")]
        public void WhenOpenCatalogPage()
        {
            var catalog = new CatalogPage();
            catalog.ClickCatalog();

        }

        [When(@"Сhoose category")]
        public void WhenСhooseCategory()
        {
            var category = new CatalogPage();
            category.ClickWireOkButton();
            Thread.Sleep(1000);
        }

        [When(@"Press the button basket")]
        public void WhenPressTheButtonBasket()
        {
            var inBasket = new CatalogPage();
            inBasket.ClickInBasketButton();
        }

        [When(@"Go to basket")]
        public void WhenGoToBasket()
        {
            var goToBasket = new CatalogPage();
            goToBasket.ClickGoToBasket();
        }

        //[When(@"I see the added item in the cart")]
        //public void WhenISeeTheAddedItemInTheCart()
        //{
        //    var basket = new CatalogPage();
        //    basket.ClickBasket();
        //}

        [When(@"Click change")]
        public void WhenClickChange()
        {
            throw new PendingStepException();
        }

        [When(@"Add product in basket")]
        public void WhenAddProductInBasket()
        {
            throw new PendingStepException();
        }

        [When(@"Click cancellation")]
        public void WhenClickCancellation()
        {
            throw new PendingStepException();
        }

        [When(@"Add product and save")]
        public void WhenAddProductAndSave()
        {
            throw new PendingStepException();
        }

        [When(@"See the change amount")]
        public void WhenSeeTheChangeAmount()
        {
            throw new PendingStepException();
        }

        [When(@"Delete item")]
        public void WhenDeleteItem()
        {
            throw new PendingStepException();
        }

        [When(@"I see a notification window about the absence of goods in the basket")]
        public void WhenISeeANotificationWindowAboutTheAbsenceOfGoodsInTheBasket()
        {
            throw new PendingStepException();
        }       

        [When(@"Open goods")]
        public void WhenOpenGoods()
        {
            throw new PendingStepException();
        }

        [When(@"Change region")]
        public void WhenChangeRegion()
        {
            throw new PendingStepException();
        }

        [When(@"Close message about theoretical weight of metal")]
        public void WhenCloseMessageAboutTheoreticalWeightOfMetal()
        {
            throw new PendingStepException();
        }

        [When(@"remove one item")]
        public void WhenRemoveOneItem()
        {
            throw new PendingStepException();
        }

        [Then(@"Delete everything")]
        public void ThenDeleteEverything()
        {
            throw new PendingStepException();
        }
    }
}
