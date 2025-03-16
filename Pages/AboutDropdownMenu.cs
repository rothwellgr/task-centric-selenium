using OpenQA.Selenium;

namespace Pages;

public class AboutDropdownMenu(IWebDriver driver)
{
    private readonly IWebDriver driver = driver;

    public IWebElement AboutSelenium => driver.FindElement(By.LinkText("About Selenium"));
}