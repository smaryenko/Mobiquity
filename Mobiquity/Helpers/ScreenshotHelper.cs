﻿using System;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Tracing;

namespace Mobiquity.Helpers
{
    public class ScreenshotHelper
    {
        public static void TakeScreenshot(IWebDriver driver)
        {
            try
            {
                string directoryName = "screenshot";
                string fileNameBase = string.Format("error_{0}_{1}_{2}",
                    FeatureContext.Current.FeatureInfo.Title.ToIdentifier(),
                    ScenarioContext.Current.ScenarioInfo.Title.ToIdentifier(),
                    DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                var artifactDirectory = Path.Combine(Directory.GetCurrentDirectory(), directoryName);
                if (!Directory.Exists(artifactDirectory))
                    Directory.CreateDirectory(artifactDirectory);

                string pageSource = driver.PageSource;
                string sourceFilePath = Path.Combine(artifactDirectory, fileNameBase + "_source.html");
                File.WriteAllText(sourceFilePath, pageSource, Encoding.UTF8);
                //Console.WriteLine("Page source: {0}", new Uri(sourceFilePath));

                ITakesScreenshot takesScreenshot = driver as ITakesScreenshot;

                if (takesScreenshot != null)
                {
                    var screenshot = takesScreenshot.GetScreenshot();

                    string screenshotFilePath = Path.Combine(artifactDirectory, fileNameBase + "_screenshot.png");

                    screenshot.SaveAsFile(screenshotFilePath, ImageFormat.Png);

                    //Console.WriteLine("Screenshot: {0}", new Uri(screenshotFilePath));
                    Console.WriteLine($"SCREENSHOT[ {Path.Combine(directoryName, new FileInfo(screenshotFilePath).Name)} ]SCREENSHOT");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while taking screenshot: {0}", ex);
            }
        }
    }
}
