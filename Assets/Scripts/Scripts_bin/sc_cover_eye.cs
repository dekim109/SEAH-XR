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

            if (sc_cover_init.type == 0) // ��� �����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� ����� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // ��� ����� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // ��� ����� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // ��� ����� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // ��� ����� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // ��� ����� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // ��� ����� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // ��� ����� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // ��� �ܻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� �ܻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // ��� �ܻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // ��� �ܻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // ��� �ܻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // ��� �ܻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // ��� �ܻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // ��� �ܻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // ��� �ܻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // ��� ����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // ��� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // ��� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // ��� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // ��� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // ��� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // ��� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // ��� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // ��� �ϻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� �ϻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // ��� �ϻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // ��� �ϻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // ��� �ϻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // ��� �ϻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // ��� �ϻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // ��� �ϻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // ��� �ϻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }
        }

        if (other.gameObject.CompareTag("eye_R") && sc_cover_init.position == 0)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // �¾� �����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� ����� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // �¾� ����� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // �¾� ����� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // �¾� ����� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // �¾� ����� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // �¾� ����� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // �¾� ����� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // �¾� ����� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // �¾� �ܻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // �¾� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // �¾� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // �¾� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // �¾� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // �¾� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // �¾� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // �¾� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // �¾� ����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // �¾� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // �¾� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // �¾� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // �¾� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // �¾� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // �¾� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // �¾� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // �¾� �ϻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� �ϻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // �¾� �ϻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // �¾� �ϻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // �¾� �ϻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // �¾� �ϻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // �¾� �ϻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // �¾� �ϻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // �¾� �ϻ�� 50��
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

            if (sc_cover_init.type == 0) // ��� �����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� ����� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // ��� ����� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // ��� ����� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // ��� ����� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // ��� ����� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // ��� ����� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // ��� ����� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // ��� ����� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // ��� �ܻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� �ܻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // ��� �ܻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // ��� �ܻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // ��� �ܻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // ��� �ܻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // ��� �ܻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // ��� �ܻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // ��� �ܻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // ��� ����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // ��� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // ��� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // ��� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // ��� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // ��� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // ��� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // ��� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // ��� �ϻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // ��� �ϻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // ��� �ϻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // ��� �ϻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // ��� �ϻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // ��� �ϻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // ��� �ϻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // ��� �ϻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // ��� �ϻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }
        }

        if (other.gameObject.CompareTag("eye_R") && sc_cover_init.position == 0)
        {
            try_number += 1;

            if (sc_cover_init.type == 0) // �¾� �����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� ����� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // �¾� ����� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // �¾� ����� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // �¾� ����� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // �¾� ����� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // �¾� ����� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // �¾� ����� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // �¾� ����� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 1) // �¾� �ܻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� �ܻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // �¾� �ܻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // �¾� �ܻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // �¾� �ܻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // �¾� �ܻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // �¾� �ܻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // �¾� �ܻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // �¾� �ܻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 2) // �¾� ����
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // �¾� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // �¾� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // �¾� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // �¾� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // �¾� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // �¾� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // �¾� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }

            if (sc_cover_init.type == 3) // �¾� �ϻ��
            {
                switch (sc_cover_init.angle)
                {
                    case 10: // �¾� �ϻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 20: // �¾� �ϻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 25: // �¾� �ϻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 30: // �¾� �ϻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 35: // �¾� �ϻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 40: // �¾� �ϻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 45: // �¾� �ϻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                    case 50: // �¾� �ϻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        eye_R.transform.localRotation = Quaternion.Euler(0, 0, 0);
                        break;
                }
            }
        }
    }
}
