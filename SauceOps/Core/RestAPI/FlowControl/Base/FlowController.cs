﻿namespace SauceOps.Core.RestAPI.FlowControl.Base {
    internal abstract class FlowController : RestBase {
        protected abstract bool TooManyTests();
        public abstract void ControlFlow();
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */