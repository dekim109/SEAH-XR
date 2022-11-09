// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.MixedReality.Toolkit.Utilities;

namespace XRDE
{
    public class CSVWriter : Singleton<CSVWriter>
    {
        #region Inspector
        public float FPS = 30.0f;
        public int Year = 1;
        #endregion
        public static string SubjectNumber = "";
        public static string SceneIndex = "";

        private SceneState currentSceneState = SceneState.Ready;
        private SceneState _previousSceneState = SceneState.Ready;

        private string _fileNamingConvention;
        private string _folderPath;
        private string _fileName;
        private string _filePath;

        private StreamWriter _outStream = null;

        private bool _isWriting = false;

        protected override void Awake()
        {
            // Set fixed update step
            Time.fixedDeltaTime = 1.0f / FPS;
        }

        private void FixedUpdate()
        {
            ContinuouslyWriteCSVFile();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();

            if (_outStream != null)
            {
                _outStream.Close();
                _outStream = null;
                _outStream.Dispose();

                Debug.Log("[SERVER] End server application. Stop CSV wrting: " + _filePath);
            }
        }

        public void CreateCSVFile(string sceneIndex_str)
        {
            // Create Folder
            _fileNamingConvention = "ETRI_" + Year.ToString() + "_" + SubjectNumber.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd").Substring(2);
            _folderPath = Path.Combine(Application.persistentDataPath, "CSV", _fileNamingConvention);
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            // Create File
            _fileName = _fileNamingConvention + "_" + sceneIndex_str;
            _filePath = Path.Combine(_folderPath, _fileName + ".csv");
            RecursiveCheckCreateFile(1);
        }

        public void OpenCSVFolder()
        {
            _fileNamingConvention = "ETRI_" + Year.ToString() + "_" + SubjectNumber.ToString() + "_" + DateTime.Now.ToString("yyyyMMdd").Substring(2);
            _folderPath = Path.Combine(Application.persistentDataPath, "CSV", _fileNamingConvention);
            if (!Directory.Exists(_folderPath))
            {
                Directory.CreateDirectory(_folderPath);
            }

            System.Diagnostics.Process.Start(_folderPath);
        }

        private void RecursiveCheckCreateFile(int frame)
        {
            if (File.Exists(_filePath))
            {
                Debug.LogWarning("[SERVER] File already exists! (" + _filePath + ")");
                _filePath = Path.Combine(_folderPath, _fileName + "(" + frame++.ToString() + ")" + ".csv");
                RecursiveCheckCreateFile(frame);
            }
            else
            {
                // Create CSV file & Set current StreamWriter
                _outStream = File.CreateText(_filePath);

                Debug.Log("[SERVER] Create new CSV file: " + _filePath);
            }
        }

        public void StartWirtingCSVFile()
        {
            _isWriting = true;
        }

        #region CSV header definition
        // When the data structure changes, it must be changed.
        private string GetCSVHeader(XRData data)
        {
             List<string> csvHeader = new List<string>();

            // TimeData
            csvHeader.Add("frame"); // 0
            csvHeader.Add("date");
            csvHeader.Add("time");
            csvHeader.Add("fps"); // 3

            // SceneData
            csvHeader.Add("scene_state"); // 4
            csvHeader.Add("scene_index"); // 5

            // HoloLensData
            // HMD
            csvHeader.Add("head_position_x"); // 6
            csvHeader.Add("head_position_y");
            csvHeader.Add("head_position_z");
            csvHeader.Add("head_rotation_x");
            csvHeader.Add("head_rotation_y");
            csvHeader.Add("head_rotation_z");
            csvHeader.Add("head_rotation_w");
            csvHeader.Add("head_tracking_state"); //13

            // Gaze
            csvHeader.Add("gaze_origin_x"); // 14
            csvHeader.Add("gaze_origin_y");
            csvHeader.Add("gaze_origin_z");
            csvHeader.Add("gaze_direction_x");
            csvHeader.Add("gaze_direction_y");
            csvHeader.Add("gaze_direction_z");
            csvHeader.Add("gaze_target_name");
            csvHeader.Add("gaze_hit_position_x");
            csvHeader.Add("gaze_hit_position_y");
            csvHeader.Add("gaze_hit_position_z");
            csvHeader.Add("gaze_hit_normal_x");
            csvHeader.Add("gaze_hit_normal_y");
            csvHeader.Add("gaze_hit_normal_z");
            csvHeader.Add("gaze_is_eye_calibration_valid");
            csvHeader.Add("gaze_is_eye_tracking_data_valid");
            csvHeader.Add("gaze_is_eye_tracking_enabled");
            csvHeader.Add("gaze_is_eye_tracking_enabled_and_valid");
            csvHeader.Add("gaze_timestamp"); // 31

            // Hand
            // Create individual joint count list
            // 32 ~ 143 (8 * 2 * 7)
            List<TrackedHandJoint> IndividualJoints = new List<TrackedHandJoint>();
            IndividualJoints.Add(TrackedHandJoint.Wrist);
            IndividualJoints.Add(TrackedHandJoint.Palm);
            IndividualJoints.Add(TrackedHandJoint.ThumbTip);
            IndividualJoints.Add(TrackedHandJoint.IndexTip);
            IndividualJoints.Add(TrackedHandJoint.MiddleTip);
            IndividualJoints.Add(TrackedHandJoint.RingTip);
            IndividualJoints.Add(TrackedHandJoint.PinkyTip);

            // Left
            foreach (TrackedHandJoint trackedHandJoint in IndividualJoints)
            {
                string jointNameHeader = "hand_joint_left_" + trackedHandJoint.ToString();
                csvHeader.Add(jointNameHeader);
                csvHeader.Add(jointNameHeader + "_position_x");
                csvHeader.Add(jointNameHeader + "_position_y");
                csvHeader.Add(jointNameHeader + "_position_z");
                csvHeader.Add(jointNameHeader + "_rotation_x");
                csvHeader.Add(jointNameHeader + "_rotation_y");
                csvHeader.Add(jointNameHeader + "_rotation_z");
                csvHeader.Add(jointNameHeader + "_rotation_w");
            }
            //Right
            foreach (TrackedHandJoint trackedHandJoint in IndividualJoints)
            {
                string jointNameHeader = "hand_joint_right_" + trackedHandJoint.ToString();
                csvHeader.Add(jointNameHeader);
                csvHeader.Add(jointNameHeader + "_position_x");
                csvHeader.Add(jointNameHeader + "_position_y");
                csvHeader.Add(jointNameHeader + "_position_z");
                csvHeader.Add(jointNameHeader + "_rotation_x");
                csvHeader.Add(jointNameHeader + "_rotation_y");
                csvHeader.Add(jointNameHeader + "_rotation_z");
                csvHeader.Add(jointNameHeader + "_rotation_w");
            }

            // Object
            // Main
            csvHeader.Add("main_object_interaction_target_name"); // 144
            csvHeader.Add("main_object_interaction_start_time");
            csvHeader.Add("main_object_interaction_end_time");
            csvHeader.Add("main_object_position_x");
            csvHeader.Add("main_object_position_y");
            csvHeader.Add("main_object_position_z");
            csvHeader.Add("main_object_rotation_x");
            csvHeader.Add("main_object_rotation_y");
            csvHeader.Add("main_object_rotation_z");
            csvHeader.Add("main_object_rotation_w"); // 153
            // Sub
            csvHeader.Add("sub_object_interaction_target_name"); // 154
            csvHeader.Add("sub_object_interaction_start_time");
            csvHeader.Add("sub_object_interaction_end_time");
            csvHeader.Add("sub_object_position_x");
            csvHeader.Add("sub_object_position_y");
            csvHeader.Add("sub_object_position_z");
            csvHeader.Add("sub_object_rotation_x");
            csvHeader.Add("sub_object_rotation_y");
            csvHeader.Add("sub_object_rotation_z");
            csvHeader.Add("sub_object_rotation_w"); // 163

            // JNU
            csvHeader.Add("JNU_stick_grab_valid"); // 164
            csvHeader.Add("JNU_stick_try_number");
            csvHeader.Add("JNU_stick_try_time");
            csvHeader.Add("JNU_cover_grab_valid");
            csvHeader.Add("JNU_cover_try_number");
            csvHeader.Add("JNU_cover_try_time");
            csvHeader.Add("JNU_prism_grab_valid");
            csvHeader.Add("JNU_prism_try_number");
            csvHeader.Add("JNU_prism_try_time"); // 172

            // Change CSV string format
            string separator = ", ";
            string csvHeader_str = String.Join(separator, csvHeader);

            return csvHeader_str;
        }
#endregion

        private void ContinuouslyWriteCSVFile()
        {
            // Get current received XRdata
            XRData data = ServerManager.ReceivedData;
            if (data == null)
            {
                return;
            }

            // Get current scene state and do each operation
            if (!Enum.TryParse<SceneState>(data.SceneData[0], true, out currentSceneState))
            {
                return;
            }
            if (currentSceneState == SceneState.Stop
                && (_previousSceneState == SceneState.Stop || _previousSceneState == SceneState.Ready))
            {
                currentSceneState = SceneState.Ready;
                _previousSceneState = currentSceneState;

                return;
            }

            // If current scene state is not SceneState.Ready,
            // Change CSV string format from current received XRData and write on file
            if (currentSceneState != SceneState.Ready)
            {
                // First stream
                if (currentSceneState == SceneState.Start
                    || (_previousSceneState == SceneState.Ready && currentSceneState == SceneState.Play))
                {
                    // Abnormal stream termination case, stop previous writing process.
                    if (_previousSceneState != SceneState.Stop
                        && _previousSceneState != SceneState.Ready)
                    {
                        Debug.LogWarning("[SERVER] Abnormal termination in client. Stop the previous writing and start new writing.");

                        StopWritingCSVFile();
                    }

                    // Get current scene index, create & start writing
                    SceneIndex = data.SceneData[1];
                    data.SceneData[0] = "Start";
                    CreateCSVFile(SceneIndex);
                    StartWirtingCSVFile();

                    // Write header (parameter name)
                    _outStream.WriteLine(GetCSVHeader(data));

                    Debug.Log("[SERVER] Start CSV wrting......");
                }

                // Write CSV
                if (_isWriting)
                {
                    List<string> data_str = new List<string>();

                    data_str.AddRange(data.TimeData);
                    data_str.AddRange(data.SceneData);
                    data_str.AddRange(data.HoloLensData);
                    data_str.AddRange(data.JNUData);

                    // Change CSV string format
                    string separator = ", ";
                    string csv_result = String.Join(separator, data_str);

                    // Write on StreamWriter
                    _outStream.WriteLine(csv_result);
                }
            }

            // If current scene state is SceneState.Stop or SceneState.Ready,
            // In next frame, stop writing on CSV
            if (currentSceneState == SceneState.Stop)
            {
                StopWritingCSVFile();
            }

            _previousSceneState = currentSceneState;
        }

        public void StopWritingCSVFile()
        {
            _isWriting = false;

            if (_outStream != null)
            {
                _outStream.Close();
                _outStream = null;

                Debug.Log("[SERVER] Stop CSV wrting: " + _filePath);
            }     
        }
    }
}
