using SauceOps.Core.OnDemand;
using System.Collections;

namespace SauceOps.Core.DataSources
{

    public class PlatformTestData {
        #region Attributes
        //internal static List<SaucePlatform> Platforms { get; set; }

        //internal string Os { get; set; }
        //internal string Platform { get; set; }
        //internal string BrowserName { get; set; }
        //internal string BrowserVersion { get; set; }
        //internal string LongName { get; set; }
        //internal string LongVersion { get; set; }
        //internal string Url { get; set; }
        //internal string Device { get; set; }
        //internal string DeviceType { get; set; }
        //internal string DeviceOrientation { get; set; }
        #endregion


        public static IEnumerable Platforms
        {
            get
            {
                yield return new SaucePlatform("Windows 10", "", "Chrome", "80.0", "", "", "", "", "");
            }
        }


        //#region Methods
        //internal double ParseBrowserVersion() {
        //    return double.Parse(BrowserVersion);
        //}

        //#endregion

        //static PlatformTestData()
        //{
        //    //Console.WriteLine("Start static PlatformTestData()");
        //    //Console.WriteLine(@"After CheckActivation in PlatformTestData");
        //    Platforms = JsonConvert.DeserializeObject<List<SaucePlatform>>(Enviro.SauceOnDemandBrowsers);
        //    //OnceOnlyMessages.TestingOn(Platforms);
        //    //OnceOnlyMessages.OnDemand();
        //}

        //public IEnumerator GetEnumerator() {
        //    return Platforms?.Select(platform => new SaucePlatform(Sanitiser.SanitisePlatformField(platform.Os),
        //                Sanitiser.SanitisePlatformField(platform.Platform),
        //                Sanitiser.SanitisePlatformField(platform.Browser),
        //                Sanitiser.SanitisePlatformField(platform.BrowserVersion),
        //                Sanitiser.SanitisePlatformField(platform.LongName),
        //                Sanitiser.SanitisePlatformField(platform.LongVersion),
        //                Sanitiser.SanitisePlatformField(platform.Url),
        //                platform.Device ?? SauceOpsConstants.NULL_STRING,
        //                platform.DeviceOrientation ?? SauceOpsConstants.NULL_STRING)).GetEnumerator();
        //}
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */