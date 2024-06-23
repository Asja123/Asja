// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class HomeworkTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void homework() {
    driver.Navigate().GoToUrl("https://qauto.forstudy.space/");
    driver.Manage().Window.Size = new System.Drawing.Size(2576, 1416);
    driver.FindElement(By.CssSelector(".btn-outline-white")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".btn-outline-white"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.Id("signinEmail")).SendKeys("anastajschen@gmail.com");
    driver.FindElement(By.Id("signinPassword")).SendKeys("12345Asdf");
    driver.FindElement(By.Id("signinEmail")).Click();
    driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".footer")).Click();
    driver.FindElement(By.LinkText("Profile")).Click();
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".btn-primary"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".close")).Click();
    driver.FindElement(By.CssSelector(".sidebar > .btn:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.Id("addCarBrand")).Click();
    {
      var dropdown = driver.FindElement(By.Id("addCarBrand"));
      dropdown.FindElement(By.XPath("//option[. = 'Porsche']")).Click();
    }
    driver.FindElement(By.Id("addCarModel")).Click();
    {
      var dropdown = driver.FindElement(By.Id("addCarModel"));
      dropdown.FindElement(By.XPath("//option[. = 'Panamera']")).Click();
    }
    driver.FindElement(By.Id("addCarMileage")).Click();
    driver.FindElement(By.Id("addCarMileage")).SendKeys("1");
    driver.FindElement(By.Id("addCarMileage")).Click();
    driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
    driver.FindElement(By.CssSelector(".sidebar > .btn:nth-child(2)")).Click();
    driver.FindElement(By.Id("carSelectDropdown")).Click();
    driver.FindElement(By.CssSelector(".car-select-dropdown_menu")).Click();
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".btn-primary"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.Id("addExpenseLiters")).Click();
    driver.FindElement(By.Id("addExpenseLiters")).SendKeys("10");
    driver.FindElement(By.Id("addExpenseTotalCost")).Click();
    driver.FindElement(By.Id("addExpenseTotalCost")).SendKeys("56");
    driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
    driver.FindElement(By.Id("addExpenseLiters")).Click();
    driver.FindElement(By.Id("addExpenseLiters")).SendKeys("100");
    driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
    driver.FindElement(By.Id("addExpenseTotalCost")).Click();
    driver.FindElement(By.Id("addExpenseTotalCost")).Click();
    driver.FindElement(By.Id("addExpenseTotalCost")).SendKeys("100");
    driver.FindElement(By.Id("addExpenseMileage")).Click();
    driver.FindElement(By.Id("addExpenseMileage")).SendKeys("15");
    driver.FindElement(By.CssSelector(".btn-primary:nth-child(2)")).Click();
    driver.FindElement(By.LinkText("Settings")).Click();
    driver.FindElement(By.Id("emailChangeEmail")).SendKeys("anastajschen@gmail.com");
    driver.FindElement(By.Id("emailChangePassword")).SendKeys("12345Asdf");
    driver.FindElement(By.CssSelector(".btn-danger-bg")).Click();
    driver.FindElement(By.CssSelector(".btn-danger")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".btn-danger"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
  }
}
