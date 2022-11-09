// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using System;
using UnityEditor;

namespace XRDE
{
    [InitializeOnLoad]
    static class ScriptOrderExecuter
    {
        static ScriptOrderExecuter()
        {
            foreach (MonoScript script in MonoImporter.GetAllRuntimeMonoScripts())
            {
                if (script.GetClass() != null)
                {
                    foreach (Attribute attr  in Attribute.GetCustomAttributes(script.GetClass(), typeof(ScriptExecutionOrder)))
                    {
                        var curOrder = MonoImporter.GetExecutionOrder(script);
                        var setOrder = ((ScriptExecutionOrder)attr).Order;
                        if (curOrder != setOrder)
                            MonoImporter.SetExecutionOrder(script, setOrder);
                    }
                }
            }
        }
    }
}