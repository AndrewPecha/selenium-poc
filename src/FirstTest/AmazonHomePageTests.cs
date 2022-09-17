using System;
using System.Threading.Tasks;
using FirstTest.POMs;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;
using Xunit.Abstractions;

namespace FirstTest;

public class AmazonHomePageTests
{
    private readonly ITestOutputHelper _testOutputHelper;
    private readonly ChromeDriver _chromeDriver;
    private readonly AmazonHomePage _page;

    public AmazonHomePageTests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;

        //this is needed to set up the driver fully
        new DriverManager().SetUpDriver(new ChromeConfig());
        _chromeDriver = new ChromeDriver();
        _page = new AmazonHomePage(_chromeDriver);
        
        _chromeDriver.Navigate().GoToUrl("https://amazon.com");
    }

    [Fact]
    public void Test1()
    {
        Console.WriteLine("First test");
        _testOutputHelper.WriteLine("First test");
        _chromeDriver.Navigate().GoToUrl("https://amazon.com");
    }

    [Fact]
    public void SearchForMysteryBook()
    {
        //Arrange

        //Act
        _page.SearchBar.SendKeys("When The Spider Strikes E.C. Pecha");
        _page.SearchButton.Click();

        //Assert
    }
}