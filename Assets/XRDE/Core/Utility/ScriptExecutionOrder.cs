// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using System;

namespace XRDE
{
    public class ScriptExecutionOrder : Attribute
    {
        public int Order;

        public ScriptExecutionOrder(int order)
        {
            this.Order = order;
        }
    }
}