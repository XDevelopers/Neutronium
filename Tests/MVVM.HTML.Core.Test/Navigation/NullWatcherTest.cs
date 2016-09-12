﻿using System;
using Neutronium.Core.Infra;
using Xunit;

namespace Neutronium.Core.Test.Navigation
{
    public class NullWatcherTest
    {
        private readonly IWebSessionLogger _nullLogger = new BasicLogger();
       
        [Fact]
        public void LogCriticalTest()
        {
            _nullLogger.Error(string.Empty);
        }

        [Fact]
        public void LogBrowserTest()
        {
            _nullLogger.LogBrowser(null, null);
        }

        [Fact]
        public void OnSessionErrorTest()
        {
            _nullLogger.WebBrowserError(new Exception(), () => { });
        }
    }
}
