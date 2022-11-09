// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace XRDE
{
    public class JNUDataExtractor : MonoBehaviour, IDataExtractor
    {
        // To-do

        // ocular motility test
        public string stick_grab_valid;
        public string stick_try_number;
        public string stick_try_time;

        // cover uncover test
        public string cover_grab_valid;
        public string cover_try_number;
        public string cover_try_time;

        // prism cover test
        public string prism_grab_valid;
        public string prism_try_number;
        public string prism_try_time;

        public void Initialize()
        {
            // To-do
            stick_grab_valid = "False";
            stick_try_number = "0";
            stick_try_time = "00:00.000";

            cover_grab_valid = "False";
            cover_try_number = "0";
            cover_try_time = "00:00.000";
        }

        public void UpdateData()
        {
            // Get JNUData list
            List<string> dataList = DataExtractorManager.Data.JNUData;

            if (XRDE.DataExtractorManager.SceneIndex == "S1_111") // Ocular Motility Test - 하
            {
                stick_grab_valid = StickData.grab_valid.ToString();
                stick_try_number = StickData.try_number.ToString();
                stick_try_time = StickData.try_time;
            }

            if (XRDE.DataExtractorManager.SceneIndex == "S1_112") // Ocular Motility Test - 상
            {
                stick_grab_valid = StickData.grab_valid.ToString();
                stick_try_number = StickData.try_number.ToString();
                stick_try_time = StickData.try_time;
            }

            if (XRDE.DataExtractorManager.SceneIndex == "S1_121") // Cover Uncover Test - 하
            {
                cover_grab_valid = CoverData.grab_valid.ToString();
                cover_try_number = CoverEyemovement.try_number.ToString();
                cover_try_time = CoverData.try_time;
            }

            if (XRDE.DataExtractorManager.SceneIndex == "S1_122") // Cover Uncover Test - 상
            {
                cover_grab_valid = CoverData.grab_valid.ToString();
                cover_try_number = CoverEyemovement.try_number.ToString();
                cover_try_time = CoverData.try_time;
            }

            if (XRDE.DataExtractorManager.SceneIndex == "S1_131") // Prism Cover Test - 하
            {
                cover_grab_valid = PrismData.cover_grab.ToString();
                cover_try_number = CoverEyemovement.try_number.ToString();
                cover_try_time = PrismData.cover_time;

                prism_grab_valid = PrismGrabValid.PrismGrab.ToString();
                prism_try_number = PrismEnter.try_num.ToString();
                prism_try_time = PrismData.prism_time;
            }

            // Debug.Log(stick_grab_valid + "+" + stick_try_number + "+" + stick_try_time);

            // To-do (example)
            dataList.Add(stick_grab_valid.ToString()); // stick_grab_valid
            dataList.Add(stick_try_number.ToString()); // stick_try_number
            dataList.Add(stick_try_time); // stick_try_time
            dataList.Add(cover_grab_valid.ToString()); // cover_grab_valid
            dataList.Add(cover_try_number.ToString()); // cover_try_number
            dataList.Add(cover_try_time); // cover_try_time
            dataList.Add(prism_grab_valid); // prism_grab_valid
            dataList.Add(prism_try_number); // prism_try_number
            dataList.Add(prism_try_time); // prism_try_time
        }

        public void Reset()
        {
            Initialize();
        }
    }
}