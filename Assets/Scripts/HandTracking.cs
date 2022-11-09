using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using Microsoft;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit.Input;

public class HandTracking : MonoBehaviour
{
    public GameObject L_thumb;
    public GameObject L_index;
    Vector3 L_dir;
    public static float L_dir_f;
    // public TMP_Text L_value;

    public GameObject R_thumb;
    public GameObject R_index;
    public static Vector3 R_dir;
    public static float R_dir_f;
    // public TMP_Text R_value;

    GameObject prism;

    MixedRealityPose pose;

    void Start()
    {
        L_thumb = Instantiate(L_thumb, this.transform);
        L_index = Instantiate(L_index, this.transform);

        R_thumb = Instantiate(R_thumb, this.transform);
        R_index = Instantiate(R_index, this.transform);

        L_dir_f = 0;
        R_dir_f = 0;
    }

    void Update()
    {
        // 왼손
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Left, out pose)) // 왼손 엄지손가락이 쭉 펴있는 상태일 때
        {
            L_thumb.transform.position = pose.Position;

            if (SceneManagement.SceneNum == 3 || SceneManagement.SceneNum == 6)
            {
                prism = L_thumb;
                XRDE.DataExtractorManager.SubInteractingObject = prism;
            }
        }
        else
        {
            XRDE.DataExtractorManager.SubInteractingObject = null;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Left, out pose)) // 왼손 검지손가락이 쭉 펴있는 상태일 때
        {
            L_index.transform.position = pose.Position;
        }

        // 각도 계산 및 시각화
        L_dir = L_index.transform.position - L_thumb.transform.position;
        L_dir_f = Vector3.Angle(L_thumb.transform.forward, L_dir);
        // L_value.text = "Left: " + Vector3.Angle(L_thumb.transform.forward, L_dir).ToString();
        // Debug.Log("Left: " + Vector3.Angle(L_thumb.transform.forward, L_dir).ToString());


        // 오른손
        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.ThumbTip, Handedness.Right, out pose)) // 오른손 엄지손가락이 쭉 펴있는 상태일 때
        {
            R_thumb.transform.position = pose.Position;
        }

        if (HandJointUtils.TryGetJointPose(TrackedHandJoint.IndexTip, Handedness.Right, out pose)) // 오른손 검지손가락이 쭉 펴있는 상태일 때
        {
            R_index.transform.position = pose.Position;
        }

        // 각도 계산 및 시각화
        R_dir = R_index.transform.position - R_thumb.transform.position;
        R_dir_f = Vector3.Angle(R_thumb.transform.forward, R_dir);
        // R_value.text = "Right: " + Vector3.Angle(R_thumb.transform.forward, R_dir).ToString();
        // Debug.Log("Right: " + Vector3.Angle(R_thumb.transform.forward, R_dir).ToString());
    }
}
