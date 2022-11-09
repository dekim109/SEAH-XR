using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_stick_data : MonoBehaviour
{
    public static bool grab_valid;

    public static int try_number;

    float timer;
    public static string try_time;

    public GameObject stick;

    public void grab_true()
    {
        grab_valid = true;

        try_number += 1;
    }

    public void grab_false()
    {
        grab_valid = false;
    }

    public void scene_stick()
    {
        // XRDE.DataExtractorManager.SceneIndex = "S1_111";
        // XRDE.DataExtractorManager.MainInteractingObject = stick;
    }

    void Start()
    {
        grab_valid = false;

        try_number = 0;

        timer = 0;
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
