﻿using MVVM.CEFGlue.Binding.HTMLBinding.V8JavascriptObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM.CEFGlue.HTMLBinding
{
    public interface IJSCSGlue
    {
        IJavascriptObject JSValue { get; }

        object CValue { get;}

        JSCSGlueType Type { get; }

        IEnumerable<IJSCSGlue> GetChildren();

        void BuilString(StringBuilder sb, HashSet<IJSCSGlue> alreadyComputed);
    }
}
