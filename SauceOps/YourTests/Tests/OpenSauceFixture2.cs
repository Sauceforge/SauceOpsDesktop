using NUnit.Framework;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Tests;
using SauceryOps.YourTests.PageObjects;
using Shouldly;

namespace SauceOps.YourTests.Tests {
    public class OpenSauceFixture2 : SauceryBase {
        public OpenSauceFixture2(SaucePlatform platform) : base(platform) {
            
        }

        [Test]
        //[Ignore("Reason")]
        public void DoSomethingOnAWebPageWithSelenium2() {
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");

            // verify the page title is correct - this is actually checked as part of the constructor above.
            Driver.Title.ShouldContain("I am a page title - Sauce Labs");
        }

        [Test]
        //[Ignore("Reason")]
        public void DoSomethingElseOnAWebPageWithSelenium2() {
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");
            // find and click the link on the page
            guineaPigPage.ClickLink();

            // verify the browser was navigated to the correct page
            Driver.Url.ShouldContain("saucelabs.com/test-guinea-pig2.html");
        }

        [Test]
        //[Ignore("Reason")]
        public void DoSomethingElseAgainOnAWebPageWithSelenium2() {
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");

            // read the useragent string off the page
            var useragent = guineaPigPage.GetUserAgent();

            useragent.ShouldNotBeNull();
        }
    }
}