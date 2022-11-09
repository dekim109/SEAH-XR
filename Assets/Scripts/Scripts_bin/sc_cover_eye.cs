using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_cover_eye : MonoBehaviour
{
    public GameObject eye_L;
    public GameObject eye_R;

    public static int try_number;

    void Start()
    {
        try_number = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("eye_L") && sc_cover_init.position == 1)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // 우안 내사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 내사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 우안 내사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 우안 내사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 우안 내사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 우안 내사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 우안 내사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 우안 내사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 우안 내사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // 우안 외사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 외사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 우안 외사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 우안 외사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 우안 외사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 우안 외사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 우안 외사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 우안 외사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 우안 외사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // 우안 상사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 상사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 우안 상사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 우안 상사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 우안 상사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 우안 상사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 우안 상사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 우안 상사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 우안 상사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // 우안 하사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 하사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 우안 하사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 우안 하사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 우안 하사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 우안 하사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 우안 하사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 우안 하사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 우안 하사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }
        }

        if (other.gameObject.CompareTag("eye_R") && sc_cover_init.position == 0)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // 좌안 내사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 내사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // 좌안 내사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // 좌안 내사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // 좌안 내사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // 좌안 내사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // 좌안 내사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // 좌안 내사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // 좌안 내사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // 좌안 외사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 우사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // 좌안 우사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // 좌안 우사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // 좌안 우사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // 좌안 우사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // 좌안 우사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // 좌안 우사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // 좌안 우사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // 좌안 상사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 상사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // 좌안 상사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // 좌안 상사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // 좌안 상사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // 좌안 상사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // 좌안 상사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // 좌안 상사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // 좌안 상사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // 좌안 하사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 하사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // 좌안 하사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // 좌안 하사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // 좌안 하사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // 좌안 하사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // 좌안 하사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // 좌안 하사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // 좌안 하사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("eye_L") && sc_cover_init.position == 1)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // 우안 내사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 내사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // 우안 내사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // 우안 내사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // 우안 내사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // 우안 내사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // 우안 내사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // 우안 내사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // 우안 내사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // 우안 외사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 외사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // 우안 외사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // 우안 외사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // 우안 외사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // 우안 외사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // 우안 외사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // 우안 외사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // 우안 외사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // 우안 상사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 상사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // 우안 상사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // 우안 상사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // 우안 상사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // 우안 상사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // 우안 상사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // 우안 상사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // 우안 상사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // 우안 하사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 우안 하사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // 우안 하사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // 우안 하사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // 우안 하사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // 우안 하사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // 우안 하사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // 우안 하사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // 우안 하사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }
        }

        if (other.gameObject.CompareTag("eye_R") && sc_cover_init.position == 0)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // 좌안 내사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 내사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 좌안 내사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 좌안 내사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 좌안 내사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 좌안 내사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 좌안 내사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 좌안 내사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 좌안 내사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // 좌안 외사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 외사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 좌안 외사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 좌안 외사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 좌안 외사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 좌안 외사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 좌안 외사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 좌안 외사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 좌안 외사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // 좌안 상사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 상사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 좌안 상사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 좌안 상사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 좌안 상사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 좌안 상사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 좌안 상사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 좌안 상사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 좌안 상사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // 좌안 하사시
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // 좌안 하사시 10도
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // 좌안 하사시 20도
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // 좌안 하사시 25도
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // 좌안 하사시 30도
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // 좌안 하사시 35도
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // 좌안 하사시 40도
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // 좌안 하사시 45도
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // 좌안 하사시 50도
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }
        }
    }
}
