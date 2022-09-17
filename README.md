# Selenium POC

This project outlines basic use-cases for Selenium/SpecFlow using Page Object Models (POMs)

## [WebDriverManager](https://github.com/rosolko/WebDriverManager.Net)
This project allows us to manage the WebDriver binaries using code.

So instead of downloading individual WebDrivers, pointing to them using a file path, and maintaining them when updates are released, 
this package simplifies everything to just a couple lines. Here's an example for setting up a Chrome Driver:

```csharp
private readonly ChromeDriver _chromeDriver;

public SetupChromeDriver()
{
    _testOutputHelper = testOutputHelper;

    new DriverManager().SetUpDriver(new ChromeConfig());
    _chromeDriver = new ChromeDriver();
}
```

The line where all the magic happens is: `new DriverManager().SetUpDriver(new ChromeConfig());`

According to the [project's readme](https://github.com/rosolko/WebDriverManager.Net#usage), this performs the following functions:
1. It checks the latest version of the WebDriver binary file
2. It downloads the binary WebDriver if it is not present in your system

There are other options to set this up manually, specify versions, etc if preferred.

## [Page Object Models](https://docs.specflow.org/projects/specflow/en/latest/Guides/PageObjectModel.html)
