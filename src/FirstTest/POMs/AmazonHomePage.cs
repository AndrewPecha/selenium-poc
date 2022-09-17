using OpenQA.Selenium;

namespace FirstTest.POMs;

public class AmazonHomePage
{
    private readonly IWebDriver _webDriver;

    public AmazonHomePage(IWebDriver webDriver)
    {
        _webDriver = webDriver;
    }

    public IWebElement SearchBar => _webDriver.FindElement(By.Id("twotabsearchtextbox"));
    public IWebElement SearchButton => _webDriver.FindElement(By.Id("nav-search-submit-button"));
}