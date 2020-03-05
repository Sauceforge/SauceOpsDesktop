using NUnit.Framework;
using OpenQA.Selenium;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Options;
using SauceOps.Core.RestAPI.FlowControl;
using SauceOps.Core.RestAPI.RecommendedAppiumVersion;
using SauceOps.Core.RestAPI.TestStatus;
using SauceOps.Core.Util;
using System;

namespace SauceOps.Core.Tests
{
    //[TestFixture]  //might not need this
    //[Parallelizable(ParallelScope.Fixtures)]
    public abstract class SauceryRoot {
        protected string TestName;
        protected readonly SaucePlatform Platform;
        protected static SauceLabsStatusNotifier SauceLabsStatusNotifier;
        internal static SauceLabsFlowController SauceLabsFlowController;
        protected static SauceLabsAppiumRecommender SauceLabsAppiumRecommender;


        protected SauceryRoot(SaucePlatform platform) {
            //Console.WriteLine(@"In SauceryRoot constructor");
            Platform = platform;
        }

        static SauceryRoot() {
            SauceLabsStatusNotifier = new SauceLabsStatusNotifier();
            SauceLabsFlowController = new SauceLabsFlowController();
        }

        [SetUp]
        public void Setup() {
            //Console.WriteLine("In Setup");
            TestName = Platform.GetTestName(TestContext.CurrentContext.Test.Name);

            //DebugMessages.PrintPlatformDetails(platform);
            // set up the desired capabilities
            var factory = new OptionFactory(Platform);
            if (factory.IsSupportedPlatform())
            {
                var opts = factory.CreateOptions(TestName);
                InitialiseDriver(opts, 60);
            } else
            {
                Console.WriteLine(SauceOpsConstants.NOT_SUPPORTED_MESSAGE);
            }
        }

        public abstract void InitialiseDriver(DriverOptions opts, int waitSecs);
        public abstract void InitialiseDriver(ICapabilities driver, int waitSecs);
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */