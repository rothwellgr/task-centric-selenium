using OpenQA.Selenium;

namespace Pages;

/// <summary>
/// You'll note only element instantiations exist on every page object. Interactions
/// per page aren't required as they're deliberately made page agnostic  - see Tasks
/// > MainTasks.cs.
/// </summary>
/// <param name="driver"></param>
public class MainPage(IWebDriver driver)
{
    private readonly IWebDriver driver = driver;

    public IWebElement AboutMenu => driver.FindElement(By.Id("navbarDropdown"));
}