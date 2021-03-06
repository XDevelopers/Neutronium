﻿using Neutronium.Core.WebBrowserEngine.JavascriptObject;

namespace Neutronium.Core.Binding.GlueObject
{
    public interface IJsCsMappedBridge : IJsCsCachableGlue
    {
        void SetMappedJsValue(IJavascriptObject jsobject);
    }
}
