using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://app.cloudqa.io/home/AutomationPracticeForm");

        try
        {
            // Locate and fill the "First name" field
            IWebElement firstName = driver.FindElement(By.Name("firstname"));
            firstName.Clear();
            firstName.SendKeys("John");

            // Locate and fill the "Last name" field
            IWebElement lastName = driver.FindElement(By.Name("lastname"));
            lastName.Clear();
            lastName.SendKeys("Doe");

            // Locate and select the "Gender" radio button
            IWebElement gender = driver.FindElement(By.XPath("//input[@type='radio' and @value='Male']"));
            gender.Click();

            // Submit the form
            IWebElement submit = driver.FindElement(By.XPath("//button[@type='submit']"));
            submit.Click();

            Console.WriteLine("Test passed!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Test failed: " + e.Message);
        }
        finally
        {
            driver.Quit();
        }
    }
}
