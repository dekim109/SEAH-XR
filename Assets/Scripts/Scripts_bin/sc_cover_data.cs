using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_cover_data : MonoBehaviour
{
    public static bool grab_valid;

    float timer;
    public static string try_time;

    public GameObject occluder;

    public void grab_true()
    {
        grab_valid = true;
    }

    public void grab_false()
    {
        grab_valid = false;
    }

    public void scene_cover()
    {
        // XRDE.DataExtractorManager.SceneIndex = "S1_121";
        // XRDE.DataExtractorManager.MainInteractingObject = occluder;
    }

    void Start()
    {
        grab_valid = false;
        try_time = "00:00.000";
    }

    void Update()
    {
        // Debug.Log(try_time);

        if (grab_valid)
        {
            timer += Time.deltaTime;
            try_time = System.TimeSpan.FromSeconds(timer).ToString(@"mm\:ss\:fff");
        }
    }
}
