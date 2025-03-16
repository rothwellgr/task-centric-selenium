# Task-centric Selenium in C#

#### (Very) High-Level Architecture

NUnit (runner and tests) -> Tasks (interactions decoupled from page objects) -> PageObjects (elements only)

#### What is this?

It's a minimal (MVP if you like) task-centric Selenium test in C#, intended to be extended. It starts from an NUnit runner. The **tests** and assertions are NUnit. The tests have interactions which have been decoupled from traditional page objects, known here as **tasks**. **page** objects are fed into the tasks. This encourages a task-centric way of creating tests, rather than getting hung up on what interactions and waits to use with which page. This is (very) loosely based on the Screenplay pattern - see: https://www.infoq.com/articles/Beyond-Page-Objects-Test-Automation-Serenity-Screenplay/

#### How to set this up and run it?

1. Git clone as usual
2. Assuming you're using dotnet cli, add the Selenium package first: `dotnet add package Selenium.WebDriver`
3. Build the project: `dotnet build`
4. Run the tests (this will trigger NUnit to run) `dotnet test`

#### ToDo:

1. Add a BDD framework - potentially reqnroll (SpecFlow looks discontinued) - see: https://reqnroll.net.
2. Make this runnable from repository dashboard