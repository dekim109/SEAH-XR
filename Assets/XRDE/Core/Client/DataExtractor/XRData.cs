// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System.Collections.Generic;

namespace XRDE
{
    public class XRData
    {
        public List<string> TimeData;
        public List<string> SceneData;
        public List<string> HoloLensData;
        public List<string> JNUData;

        public void Init()
        {
            TimeData = new List<string>();
            SceneData = new List<string>();
            HoloLensData = new List<string>();
            JNUData = new List<string>();
        }

        public void Clear()
        {
            TimeData.Clear();
            SceneData.Clear();
            HoloLensData.Clear();
            JNUData.Clear();
        }
    }

    public enum SceneState
    {
        Ready,
        Start,
        Play,
        Stop
    }

    public class XRDEConstants
    {
        #region Script execution order
        public const int DATA_EXTRACTOR_MANAGER_ORDER = -10;
        public const int CLIENT_MANAGER_ORDER = -9;
        #endregion
    }
}