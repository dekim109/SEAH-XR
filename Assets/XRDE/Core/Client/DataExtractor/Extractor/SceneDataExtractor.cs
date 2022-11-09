// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System.Collections.Generic;

namespace XRDE
{
    public class SceneDataExtractor : MonoBehaviour, IDataExtractor
    {
        public void Initialize()
        {

        }

        public void UpdateData()
        {
            // Get SceneData list
            List<string> dataList = DataExtractorManager.Data.SceneData;

            // SceneData[0] must be current scene state
            dataList.Add(DataExtractorManager.SceneState.ToString());
            dataList.Add(DataExtractorManager.SceneIndex);
        }

        public void Reset()
        {
            Initialize();
        }
    }
}