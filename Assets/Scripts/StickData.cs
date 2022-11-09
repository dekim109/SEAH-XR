using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickData : MonoBehaviour
{
    public static bool grab_valid;
    public static int try_number;

    float timer;
    public static string try_time;

    public GameObject stick;

    public void grab_true()
    {
        XRDE.DataExtractorManager.MainInteractingObject = stick;

        grab_valid = true;
        try_number += 1;
    }

    public void grab_false()
    {
        XRDE.DataExtractorManager.MainInteractingObject = null;

        grab_valid = false;
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
        if (grab_valid)
        {
            timer += Time.deltaTime;
            try_time = System.TimeSpan.FromSeconds(timer).ToString(@"mm\:ss\:fff");
        }
    }
}

