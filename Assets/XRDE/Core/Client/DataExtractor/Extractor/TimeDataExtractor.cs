// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.Collections.Generic;

namespace XRDE
{
    public class TimeDataExtractor : MonoBehaviour, IDataExtractor
    {
        private int _frame;
        private string _date;
        private float _deltaTime;

        public void Initialize()
        {
            _frame = 0;
            _date = DateTime.Now.ToString("yyyy-MM-dd");
            _deltaTime = 0.0f;
        }

        public void UpdateData()
        {
            // Get TimeData list
            List<string> dataList = DataExtractorManager.Data.TimeData;

            _deltaTime += (Time.unscaledDeltaTime - _deltaTime) * 0.1f;

            dataList.Add((_frame++).ToString());
            dataList.Add(_date);
            dataList.Add(DateTime.Now.ToString("HH:mm:ss.fff"));
            dataList.Add(((float)(System.Math.Round((1.0f / _deltaTime), 3))).ToString());
        }

        public void Reset()
        {
            Initialize();
        }
    }
}