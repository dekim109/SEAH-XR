using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_motility : MonoBehaviour
{
    public GameObject eye_L;
    public GameObject SEAH;

    // Start is called before the first frame update
    void Start()
    {
        eye_L.transform.localRotation = Quaternion.Euler(0, -30, 0);

    }

    // Update is called once per frame
    void Update()
    {
        float angle = eye_L.transform.localEulerAngles.y;
        if (angle > -30)
        {
            angle = -30;
        }
    }
}
