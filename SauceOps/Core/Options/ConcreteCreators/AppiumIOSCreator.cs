using SauceOps.Core.Options.ConcreteProducts;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Options.Base;

namespace SauceOps.Core.Options.ConcreteCreators
{
    internal class AppiumIOSCreator : Creator {
        public override BaseOptions Create(SaucePlatform platform, string testName)
        {
            return new AppiumIOSOptions(platform, testName);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */