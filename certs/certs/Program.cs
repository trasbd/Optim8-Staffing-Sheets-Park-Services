using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace certs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> areaCertNames = new List<string>();
            List<string> psArea1 = new List<string>();
            List<string> psArea2 = new List<string>();
            List<string> psArea3 = new List<string>();
            List<string> psArea4 = new List<string>();

            List<List<string>> areas = new List<List<string>>();
            areas.Add(psArea1);
            areas.Add(psArea2);
            areas.Add(psArea3);
            areas.Add(psArea4);


            areaCertNames.Add("PS - Area 1");
            areaCertNames.Add("PS - Area 2");
            areaCertNames.Add("PS - Area 3");
            areaCertNames.Add("PS - Area 4");

            IWebDriver driver = new ChromeDriver();

            string certUrl = "https://sixflags.team/tm/hr/cert";

            driver.Navigate().GoToUrl(certUrl);

            if(!driver.Url.Equals(certUrl))
            {
                //not logged in
                //Console.WriteLine(driver.Url);
                Console.ReadLine();
                driver.Navigate().GoToUrl(certUrl);

            }

            

            SelectElement departmentDropDown = new SelectElement(driver.FindElement(By.Id("ddd2")));
            departmentDropDown.SelectByText("Park Services");

            for (int i = 0; i < 4; i++)
            {

                SelectElement certName = new SelectElement(driver.FindElement(By.Id("ddcert")));
                certName.SelectByText(areaCertNames[i]);

                IWebElement goBtn = driver.FindElement(By.Id("divgo"));
                goBtn.Click();

                IWebElement totalLines = driver.FindElement(By.Id("spanpagetotal"));

                IWebElement pageSize = driver.FindElement(By.Id("txtpagesize"));
                if (pageSize.Displayed)
                {
                    pageSize.SendKeys(totalLines.Text);
                    driver.FindElement(By.Id("divpagesearch")).Click();
                    Thread.Sleep(10000);
                }

                
                ReadOnlyCollection<IWebElement> names = driver.FindElements(By.TagName("tr"));

                //string certs = driver.FindElement(By.Id("tbgrid1")).Text;

                int lastNameIndex = 2;
                int firstNameIndex = 3;
                //int certNameIndex = 5;

                foreach (IWebElement person in names)
                {
                    ReadOnlyCollection<IWebElement> personElements = person.FindElements(By.TagName("td"));
                    //if (personElements[certNameIndex].Text.Equals(areaCertNames[i]))
                    //{
                        areas[i].Add(personElements[lastNameIndex].Text + ", " + personElements[firstNameIndex].Text);
                    //}
                }

            }

            Console.ReadLine();
            //Closes browser
            driver.Quit();

        }
    }
}
