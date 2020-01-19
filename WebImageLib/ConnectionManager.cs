using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebImageLib
{
    public static class ConnectionManager
    {
        static IWebDriver Driver;
        static ChromeOptions chromeOptions;
        static WebDriverWait wait;
        static int StartRange, EndRange;
        static bool ScrapeState = false;

        public static void SetCapabilities()
        {
            chromeOptions = new ChromeOptions();
            //chromeOptions.AddAdditionalCapability("download.default_directory", "C:\\Results\\");
            //chromeOptions.AddAdditionalCapability("download.prompt_for_download", "false");
            //chromeOptions.AddAdditionalCapability("plugins.plugins_disabled", "Chrome PDF Viewer");

        }

        public static void SaveImage(int RollNumber)
        {
            (Driver as ITakesScreenshot).GetScreenshot().SaveAsFile($"./Results\\{RollNumber}.png", ScreenshotImageFormat.Png);
        }

        /// <summary>
        /// Start Initialisation of Driver and Wait
        /// </summary>
        public static void Initialise()
        {
            Driver = new ChromeDriver(chromeOptions);
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            Driver.Navigate().GoToUrl("https://rtmnuresults.org");
        }

        /// <summary>
        /// Gets input in string format of start and end
        /// </summary>
        /// <param name="x">String Start Value</param>
        /// <param name="y">String End Value</param>
        public static void RangeSelect(int x, int y)
        {
            StartRange = x;
            EndRange = y;
        }

        /// <summary>
        /// Accepts a valid Integer
        /// </summary>
        /// <returns>Integer Value from keyboard</returns>
        public static int GetNumber()
        {
            while (true)
            {
                int temp = 0;
                if (int.TryParse(Console.ReadLine(), out temp))
                {
                    return temp;
                }
                else
                {
                    Logger.Log("Please input an integer ", 1);
                }
            }
        }

        /// <summary>
        /// Selects appropriate one according to user on Webpage;
        /// </summary>
        /// <param name="ID">ID of WebElement</param>
        public static void ListSelector(string ID, int Index)
        {

            SelectElement Selector = new SelectElement(Driver.FindElement(By.Name(ID)));
            Selector.SelectByIndex(Index);
        }

        /// <summary>
        /// Gets List of Combobox Items
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>IEnumerable<String></returns>
        public static IEnumerable<String> GetList(string ID)
        {

            SelectElement Selector = new SelectElement(Driver.FindElement(By.Name(ID)));
            return Selector.Options.Select(i => i.Text);
        }

        /// <summary>
        /// Basic Wait Function for webpage load
        /// </summary>
        public static void WaitForReady()
        {
            WebDriverWait tempwait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));
            tempwait.Until(driver => (bool)((IJavaScriptExecutor)driver).
                    ExecuteScript("return jQuery.active == 0"));
        }


        public static void ShowResult(int RollNumber)
        {
            Driver.FindElement(By.Id("txtrollno")).SendKeys( "\b\b\b\b\b\b\b\b\b\b" + RollNumber.ToString());
            Driver.FindElement(By.Id("imgbtnviewmarksheet")).Click();
            SaveImage(RollNumber);
        }

        public static void SetScrapeState(bool State)
        {
            ScrapeState = State;
        }

        /// <summary>
        /// Starts Scraping Images until ScrapeState is false
        /// </summary>
        public static void Scrape()
        {
            for (int i = StartRange; i <= EndRange; i++)
            {
                if (ScrapeState)
                {
                    ShowResult(i);
                    Driver.Navigate().Back();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
