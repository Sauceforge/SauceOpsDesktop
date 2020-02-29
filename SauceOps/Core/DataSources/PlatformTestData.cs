using SauceOps.Core.OnDemand;
using System.Collections;

namespace SauceOps.Core.DataSources
{
    public class PlatformTestData {
        public static IEnumerable Platforms
        {
            get
            {
                //Desktop Platforms
                yield return new SaucePlatform("Windows 10", "chrome", "latest", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "chrome", "62", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "chrome", "61", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "firefox", "54", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "firefox", "53", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "safari", "12", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "safari", "11", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "internet explorer", "11", "", "", "", "", "", "");
                yield return new SaucePlatform("Windows 10", "microsoftedge", "80", "", "", "", "", "", "");
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */