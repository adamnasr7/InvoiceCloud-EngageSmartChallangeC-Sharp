using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;
using NUnit.Framework;
using System.Collections.Generic;

namespace Invoice_Cloud_Engage_Smart_Challange.scripts
{
	public class Tests
	{
		
		[SetUp]
		public void SetUp()
		{
			
		}
		[Test]
		public void TestChallange()
		{
			IWebDriver driver = new ChromeDriver();

			driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/add_remove_elements/");

			IWebElement addRemoveElement = driver.FindElement(By.CssSelector("div:nth-child(3) > button"));
			

			int numbersAdded = 10;


            for (int i = 0; i < numbersAdded; i++)
			{
				addRemoveElement.Click();
				
			}

			IReadOnlyCollection<IWebElement> elementsAdded = driver.FindElements(By.CssSelector("button.added-manually[onclick='deleteElement()']"));

			Assert.That(numbersAdded, Is.EqualTo(elementsAdded.Count)); 



			driver.Quit(); 
			
		}

	}
}

