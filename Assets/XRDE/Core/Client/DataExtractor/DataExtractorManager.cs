// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.Collections.Generic;

namespace XRDE
{
    [ScriptExecutionOrder(XRDEConstants.DATA_EXTRACTOR_MANAGER_ORDER)]
    public class DataExtractorManager : MonoBehaviour
    {
        #region inspector
        [Header("Setting")]
        public float FPS = 30.0f;
        [Header("Data category")]
        public bool HoloLens = true;
        public bool JNU = true;
        #endregion

        // Main data structure
        public static XRData Data;

        // Scene data (essential*,  every frame)
        public static SceneState SceneState;
        public static string SceneIndex;

        // HoloLens data
        // Interaction object (essential*)
        // Main (ex. right hand)
        public static GameObject MainInteractingObject; // Set "null" when not interacting.
        public static DateTime MainInteractionStartTime;
        public static DateTime MainInteractionEndTime;
        // Sub (ex. left hand)
        public static GameObject SubInteractingObject; // Set "null" when not interacting.
        public static DateTime SubInteractionStartTime;
        public static DateTime SubInteractionEndTime;


        // Data extractor
        private List<IDataExtractor> _dataExtractors;
        public static bool IsExtracting = false; // Current frame
        private bool _isExtracted = false; // Previous frame

       
        private void Awake()
        {
            // Set fixed update step
            Time.fixedDeltaTime = 1.0f / FPS;

            // Create XRData structure
            Data = new XRData();
            Data.Init();
            SceneState = SceneState.Ready;

            // Create DataExtractor list
            _dataExtractors = new List<IDataExtractor>();
            IDataExtractor dataExtractor;

            // Create and init each data extractor
            // If you want to add new data category, 
            // Must follow below process and write each IDataExtractor.UpdateData()
            {
                // TimeData
                gameObject.AddComponent<TimeDataExtractor>();
                dataExtractor = this.GetComponent<TimeDataExtractor>();
                _dataExtractors.Add(dataExtractor);
                dataExtractor.Initialize();

                // SceneData
                gameObject.AddComponent<SceneDataExtractor>();
                dataExtractor = this.GetComponent<SceneDataExtractor>();
                _dataExtractors.Add(dataExtractor);
                dataExtractor.Initialize();

                // HoloLensData
                if (HoloLens)
                {
                    gameObject.AddComponent<HoloLensDataExtractor>();
                    dataExtractor = this.GetComponent<HoloLensDataExtractor>();
                    _dataExtractors.Add(dataExtractor);
                    dataExtractor.Initialize();
                }

                // JNU
                if (JNU)
                {
                    gameObject.AddComponent<JNUDataExtractor>();
                    dataExtractor = this.GetComponent<JNUDataExtractor>();
                    _dataExtractors.Add(dataExtractor);
                    dataExtractor.Initialize();
                }
            }
        }

        private void FixedUpdate()
        {
            // Clear XRData each frame
            Data.Clear();

            if (IsExtracting)
            {
                SceneState = _isExtracted != IsExtracting ? SceneState.Start : SceneState.Play;

                // Update extracting process
                UpdateDataExtractor();
            }
            else
            {
                SceneState = _isExtracted != IsExtracting ? SceneState.Stop : SceneState.Ready;

                if (SceneState == SceneState.Stop)
                {
                    // Update last 1 frame data by stop sign
                    UpdateDataExtractor();

                    ResetDataExtractor();
                }
            }

            _isExtracted = IsExtracting;
        }

        public void StartDataExtractor()
        {
            // Abnormal scene termination case
            if (IsExtracting == true)
            {
                _isExtracted = false;
                ResetDataExtractor();

                Debug.LogWarning("[CLIENT] Abnormal termination on data extractor. Restart data extractor");
            }
            else
            {
                Debug.Log("[CLIENT] Start data extractor.");
            }

            IsExtracting = true; 
        }

        private void UpdateDataExtractor()
        {
            foreach (IDataExtractor dataExtractor in _dataExtractors)
            {
                dataExtractor.UpdateData();
            }
        }

        private void ResetDataExtractor()
        {
            foreach (IDataExtractor dataExtractor in _dataExtractors)
            {
                dataExtractor.Reset();
            }
        }

        public void StopDataExtractor()
        {
            IsExtracting = false;

            Debug.Log("[CLIENT] Stop data extractor.");
        }
    }
}