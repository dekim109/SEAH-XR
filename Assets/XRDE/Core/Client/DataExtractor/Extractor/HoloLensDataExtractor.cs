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
    public class HoloLensDataExtractor : MonoBehaviour, IDataExtractor
    {
        // HMD
        private Headset _headset;
        private Transform _hmd;

        // Gaze
        IMixedRealityGazeProvider _gazeProvider;
        IMixedRealityEyeGazeProvider _eyeProvider;

        // Hand
        IMixedRealityHandJointService _handService;
        private Transform _handJoint;
        private string _jointNameHeader;
        private List<TrackedHandJoint> _individualJoints = new List<TrackedHandJoint>();

        public void Initialize()
        {
            // HMD
            _hmd = CameraCache.Main.transform;

            // Gaze
            _gazeProvider = CoreServices.InputSystem.GazeProvider;
            _eyeProvider = CoreServices.InputSystem.EyeGazeProvider;

            // Hand
            _handService = CoreServices.GetInputSystemDataProvider<IMixedRealityHandJointService>();

            _individualJoints.Add(TrackedHandJoint.Wrist);
            _individualJoints.Add(TrackedHandJoint.Palm);
            _individualJoints.Add(TrackedHandJoint.ThumbTip);
            _individualJoints.Add(TrackedHandJoint.IndexTip);
            _individualJoints.Add(TrackedHandJoint.MiddleTip);
            _individualJoints.Add(TrackedHandJoint.RingTip);
            _individualJoints.Add(TrackedHandJoint.PinkyTip);
        }

        public void UpdateData()
        {
            // Get HoloLensData list
            List<string> dataList = DataExtractorManager.Data.HoloLensData;

            // HMD
            dataList.Add(_hmd.position.x.ToString());
            dataList.Add(_hmd.position.y.ToString());
            dataList.Add(_hmd.position.z.ToString());
            dataList.Add(_hmd.rotation.x.ToString());
            dataList.Add(_hmd.rotation.y.ToString());
            dataList.Add(_hmd.rotation.z.ToString());
            dataList.Add(_hmd.rotation.w.ToString());
            dataList.Add(_headset.TrackingState == TrackingState.Tracked ? "true" : "false");

            // Gaze
            dataList.Add(_gazeProvider.GazeOrigin.x.ToString());
            dataList.Add(_gazeProvider.GazeOrigin.y.ToString());
            dataList.Add(_gazeProvider.GazeOrigin.z.ToString());
            dataList.Add(_gazeProvider.GazeDirection.x.ToString());
            dataList.Add(_gazeProvider.GazeDirection.y.ToString());
            dataList.Add(_gazeProvider.GazeDirection.z.ToString());
            dataList.Add(_gazeProvider.GazeTarget == null ? "-" : _gazeProvider.GazeTarget.name.ToString());
            dataList.Add(_gazeProvider.HitNormal.x.ToString());
            dataList.Add(_gazeProvider.HitNormal.y.ToString());
            dataList.Add(_gazeProvider.HitNormal.z.ToString());
            dataList.Add(_gazeProvider.HitPosition.x.ToString());
            dataList.Add(_gazeProvider.HitPosition.y.ToString());
            dataList.Add(_gazeProvider.HitPosition.z.ToString());
            dataList.Add(_eyeProvider.IsEyeCalibrationValid.ToString());
            dataList.Add(_eyeProvider.IsEyeTrackingDataValid.ToString());
            dataList.Add(_eyeProvider.IsEyeTrackingEnabled.ToString());
            dataList.Add(_eyeProvider.IsEyeTrackingEnabledAndValid.ToString());
            dataList.Add(_eyeProvider.Timestamp.ToString("hh-mm-ss.fff"));

            // Hand
            // Left
            foreach (TrackedHandJoint trackedHandJoint in _individualJoints)
            {
                _handJoint = _handService.RequestJointTransform(trackedHandJoint, Handedness.Left);
                _jointNameHeader = "hand_joint_left_" + trackedHandJoint.ToString();
                dataList.Add(_jointNameHeader);
                if (_handJoint == null)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        dataList.Add("-");
                    }
                }
                else
                {
                    dataList.Add(_handJoint.position.x.ToString());
                    dataList.Add(_handJoint.position.y.ToString());
                    dataList.Add(_handJoint.position.z.ToString());
                    dataList.Add(_handJoint.rotation.x.ToString());
                    dataList.Add(_handJoint.rotation.y.ToString());
                    dataList.Add(_handJoint.rotation.z.ToString());
                    dataList.Add(_handJoint.rotation.w.ToString());
                }
            }
            //Right
            foreach (TrackedHandJoint trackedHandJoint in _individualJoints)
            {
                _handJoint = _handService.RequestJointTransform(trackedHandJoint, Handedness.Right);
                _jointNameHeader = "hand_joint_right_" + trackedHandJoint.ToString();
                dataList.Add(_jointNameHeader);
                if (_handJoint == null)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        dataList.Add("-");
                    }
                }
                else
                {
                    dataList.Add(_handJoint.position.x.ToString());
                    dataList.Add(_handJoint.position.y.ToString());
                    dataList.Add(_handJoint.position.z.ToString());
                    dataList.Add(_handJoint.rotation.x.ToString());
                    dataList.Add(_handJoint.rotation.y.ToString());
                    dataList.Add(_handJoint.rotation.z.ToString());
                    dataList.Add(_handJoint.rotation.w.ToString());
                }
            }

            // Object
            // Main
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.name.ToString());
            dataList.Add(DataExtractorManager.MainInteractionStartTime == null ? "-" : DataExtractorManager.MainInteractionStartTime.ToString("HH:mm:ss.fff"));
            dataList.Add(DataExtractorManager.MainInteractionEndTime == null ? "-" : DataExtractorManager.MainInteractionEndTime.ToString("HH:mm:ss.fff"));
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.position.x.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.position.y.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.position.z.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.rotation.w.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.rotation.x.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.rotation.y.ToString());
            dataList.Add(DataExtractorManager.MainInteractingObject == null ? "-" : DataExtractorManager.MainInteractingObject.transform.rotation.z.ToString());
            // Sub
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.name.ToString());
            dataList.Add(DataExtractorManager.SubInteractionStartTime == null ? "-" : DataExtractorManager.SubInteractionStartTime.ToString("HH:mm:ss.fff"));
            dataList.Add(DataExtractorManager.SubInteractionEndTime == null ? "-" : DataExtractorManager.SubInteractionEndTime.ToString("HH:mm:ss.fff"));
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.position.x.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.position.y.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.position.z.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.rotation.w.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.rotation.x.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.rotation.y.ToString());
            dataList.Add(DataExtractorManager.SubInteractingObject == null ? "-" : DataExtractorManager.SubInteractingObject.transform.rotation.z.ToString());
        }

        public void Reset()
        {
            Initialize();
        }
    }
}