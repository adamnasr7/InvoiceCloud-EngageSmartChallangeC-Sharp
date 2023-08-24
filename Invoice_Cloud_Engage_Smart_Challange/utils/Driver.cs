using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace _NET_UI_Automation_6.utils
{
    public class Driver
    {
        private static IWebDriver driver;
        private Driver()
        {
        }
        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                // Set up driver
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
                driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            }
            return driver;
        }
        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}