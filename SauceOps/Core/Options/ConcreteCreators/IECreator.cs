using SauceOps.Core.Options.Base;
using SauceOps.Core.Options.ConcreteProducts;
using SauceOps.Core.OnDemand;

namespace SauceOps.Core.Options.ConcreteCreators {
    internal class IECreator : Creator {
        public override BaseOptions Create(SaucePlatform platform, string testName) {
            return new IEBrowserOptions(platform, testName);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 5th February 2020
 * 
 */