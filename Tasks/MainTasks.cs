using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Tasks;

/// <summary>
/// You'll note in the tests, that they're primarily driven by Tasks. They're interactions 
/// with the page, decoupled from traditional page objects. You pass page elements through
/// them, where waits are applied to them in a page agnostic way.
/// 
/// You can separate and combine tasks, and split classes, as required.
/// </summary>
/// <param name="driver"></param>
public class MainTasks(IWebDriver driver)
{
    private readonly IWebDriver driver = driver;

    public void ClickAction(IWebElement element) 
    {
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
        wait.Until(e => element.Displayed);
        element.Click();
    }

    public bool AssertTextExists(IWebElement element, string text)
    {
        WebDriverWait wait = new(driver, TimeSpan.FromSeconds(5));
        return wait.Until(e => element.Text == text);
    }
}