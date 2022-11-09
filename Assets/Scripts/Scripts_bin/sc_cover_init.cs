using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class sc_cover_init : MonoBehaviour
{
    public static int type; // 0: 내사시, 1: 외사시, 2: 상사시, 3: 하사시
    public static int position; // 0: Left, 1: Right
    public static int angle; // 10, 20, 25, 30, 35, 40, 45, 50

    public GameObject eye_L;
    public GameObject eye_R;


    public TMP_Text currentstatus;
    public TMP_Dropdown dropdown_position;
    public TMP_Dropdown dropdown_type;
    public TMP_Dropdown dropdown_angle;

    // 중간보고 파일럿용(우안 외사시 20도)
    void Start()
    {
        position = 0;
        type = 0;
        angle = 0;

        setting();
    }

    void Update()
    {
        // Debug.Log("position: " + position + " / type: " + type + " / angle: " + angle);
    }

    void setting()
    {
        // 현재 시나리오 설정 텍스트로 시각화
        currentstatus.text = "SEAH: " + position + " / " + type + " / " + angle;

        // 사시 증상별 초기 안구 회전 각도 설정
        if (type == 0) // 내사시
        {
            if (position == 0) // 좌안 내사시
            {
                switch (angle)
                {
                    case 10: // 좌안 내사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        Debug.Log("좌안 내사시 10도");
                        break;
                    case 20: // 좌안 내사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        Debug.Log("좌안 내사시 20도");
                        break;
                    case 25: // 좌안 내사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        Debug.Log("좌안 내사시 25도");
                        break;
                    case 30: // 좌안 내사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        Debug.Log("좌안 내사시 30도");
                        break;
                    case 35: // 좌안 내사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        Debug.Log("좌안 내사시 35도");
                        break;
                    case 40: // 좌안 내사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        Debug.Log("좌안 내사시 40도");
                        break;
                    case 45: // 좌안 내사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        Debug.Log("좌안 내사시 45도");
                        break;
                    case 50: // 좌안 내사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        Debug.Log("좌안 내사시 50도");
                        break;
                }
            }

            if (position == 1) // 우안 내사시
            {
                switch (angle)
                {
                    case 10: // 우안 내사시 10도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // 우안 내사시 20도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // 우안 내사시 25도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // 우안 내사시 30도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // 우안 내사시 35도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // 우안 내사시 40도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // 우안 내사시 45도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // 우안 내사시 50도
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }
        }

        
        if (type == 1) // 외사시
        {
            if (position == 0) // 좌안 외사시
            {
                switch (angle)
                {
                    case 10: // 좌안 외사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // 좌안 외사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // 좌안 외사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // 좌안 외사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // 좌안 외사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // 좌안 외사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // 좌안 외사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // 좌안 외사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (position == 1) // 우안 외사시
            {
                switch (angle)
                {
                    case 10: // 우안 외사시 10도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // 우안 외사시 20도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // 우안 외사시 25도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // 우안 외사시 30도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // 우안 외사시 35도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // 우안 외사시 40도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // 우안 외사시 45도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // 우안 외사시 50도
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }
        }

        
        if (type == 2) // 상사시
        {
            if (position == 0) // 좌안 상사시
            {
                switch (angle)
                {
                    case 10: // 좌안 상사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // 좌안 상사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // 좌안 상사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // 좌안 상사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // 좌안 상사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // 좌안 상사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // 좌안 상사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // 좌안 상사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }

            if (position == 1) // 우안 상사시
            {
                switch (angle)
                {
                    case 10: // 우안 상사시 10도
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // 우안 상사시 20도
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // 우안 상사시 25도
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // 우안 상사시 30도
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // 우안 상사시 35도
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // 우안 상사시 40도
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // 우안 상사시 45도
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // 우안 상사시 50도
                        eye_R.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }
        }


        if (type == 3) // 하사시
        {
            if (position == 0) // 좌안 하사시
            {
                switch (angle)
                {
                    case 10: // 좌안 하사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // 좌안 하사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // 좌안 하사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // 좌안 하사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // 좌안 하사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // 좌안 하사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // 좌안 하사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // 좌안 하사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }

            if (position == 1) // 우안 하사시
            {
                switch (angle)
                {
                    case 10: // 우안 하사시 10도
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // 우안 하사시 20도
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // 우안 하사시 25도
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // 우안 하사시 30도
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // 우안 하사시 35도
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // 우안 하사시 40도
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // 우안 하사시 45도
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // 우안 하사시 50도
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }
        }
    }

    
    // 시나리오 세팅(btn)
    public void reload_seah()
    {
        switch (dropdown_position.value)
        {
            case 0:
                position = 0;
                break;
            case 1:
                position = 1;
                break;
        }

        switch (dropdown_type.value)
        {
            case 0:
                type = 0;
                break;
            case 1:
                type = 1;
                break;
            case 2:
                type = 2;
                break;
            case 3:
                type = 3;
                break;
        }

        switch (dropdown_angle.value)
        {
            case 0:
                angle = 10;
                break;
            case 1:
                angle = 20;
                break;
            case 2:
                angle = 25;
                break;
            case 3:
                angle = 30;
                break;
            case 4:
                angle = 35;
                break;
            case 5:
                angle = 40;
                break;
            case 6:
                angle = 45;
                break;
            case 7:
                angle = 50;
                break;
        }

        setting();
    }


}
