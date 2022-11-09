using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismData : MonoBehaviour
{
    public GameObject occluder;
    public static bool cover_grab;
    public static string cover_time;
    float cover_timer;

    public static string prism_time;
    float prism_timer;


    public void cover_grab_true()
    {
        cover_grab = true;
        XRDE.DataExtractorManager.MainInteractingObject = occluder;
    }

    public void cover_grab_false()
    {
        cover_grab = true;
        XRDE.DataExtractorManager.MainInteractingObject = null;
    }

    void Start()
    {
        cover_grab = false;
        cover_time = "00:00.000";
    }

    void Update()
    {
        if (cover_grab)
        {
            cover_timer += Time.deltaTime;
            cover_time = System.TimeSpan.FromSeconds(cover_timer).ToString(@"mm\:ss\:fff");
        }

        if (PrismGrabValid.PrismGrab)
        {
            prism_timer += Time.deltaTime;
            prism_time = System.TimeSpan.FromSeconds(prism_timer).ToString(@"mm\:ss\:fff");
        }
    }
}
