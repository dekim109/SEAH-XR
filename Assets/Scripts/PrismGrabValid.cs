using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrismGrabValid : MonoBehaviour
{
    public static bool PrismGrab;
    
    public GameObject eye_L;
    public GameObject eye_R;
    public GameObject Occluder;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 왼손에 쥔 프리즘 각도에 따른 bool값 설정
        if (HandTracking.L_dir_f >= 85 && HandTracking.L_dir_f <= 95)
        {
            PrismGrab = true;
        }

        else
        {
            PrismGrab = false;
        }

        // Debug.Log(PrismGrab + HandTracking.L_dir_f.ToString());
    }
}
