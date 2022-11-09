using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismEnter : MonoBehaviour
{
    public GameObject eye_L;
    public GameObject eye_R;

    public GameObject Occluder;

    public static int try_num;

    void Start()
    {
        try_num = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (CoverInit.type == 0 && other.CompareTag("thumb"))
        {
            try_num += 1;

            if (PrismGrabValid.PrismGrab)
            {
                eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                Occluder.SetActive(false);
            }
        }

        if (CoverInit.type == 1 && other.CompareTag("thumb"))
        {
            try_num += 1;

            if (PrismGrabValid.PrismGrab)
            {
                eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                Occluder.SetActive(false);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (CoverInit.type == 0)
        {
            if (!PrismGrabValid.PrismGrab || other.CompareTag("thumb"))
            {
                eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                Occluder.SetActive(true);
            }
        }

        if (CoverInit.type == 1)
        {
            if (!PrismGrabValid.PrismGrab || other.CompareTag("thumb"))
            {
                eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                Occluder.SetActive(true);
            }
        }
    }
}
