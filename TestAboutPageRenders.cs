using OpenQA.Selenium.Chrome;
using Tasks;
using Pages;

namespace Tests;

/// <summary>
/// (Very) simple (at this stage) NUnit tests. As you can see, we don't require any 
/// test-level pattern/design yet. But as we add more tests, it will probably be apparent 
/// that we will.
/// </summary>
public class Tests
{
    private readonly ChromeDriver driver = new();
    private MainTasks Actions => new(driver);
    private MainPage MainPage => new(driver);
    private AboutDropdownMenu AboutDropdownMenu => new(driver);
    private AboutPage AboutPage => new(driver);

    [SetUp]
    public void Setup()
    {           
        driver.Navigate().GoToUrl("https://selenium.dev");
    }

    [Test]
    public void TestAboutPageRenders()
    {
        Actions.ClickAction(MainPage.AboutMenu);
        Actions.ClickAction(AboutDropdownMenu.AboutSelenium);
        var result = Actions.AssertTextExists(AboutPage.AboutPageTitle, "About Selenium");
        Assert.That(result, Is.True);
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}