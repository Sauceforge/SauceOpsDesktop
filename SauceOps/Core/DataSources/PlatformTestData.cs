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
                yield return new SaucePlatform("Windows 10", //platformName
                                               "Chrome",     //browser
                                               "80.0",       //browserVersion
                                               "",           //platform
                                               "",           //longName
                                               "",           //longVersion
                                               "",           //url
                                               "",           //device
                                               "");          //deviceOrientation
                //iOS Platforms
                yield return new SaucePlatform("", "", "13.0", "", "", "", "", "iPhone XR Simulator", "portrait");

                //Android Platforms
                yield return new SaucePlatform("", "", "8.1", "", "", "", "", "Samsung Galaxy Tab S3 GoogleAPI Emulator", "portrait");

            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */