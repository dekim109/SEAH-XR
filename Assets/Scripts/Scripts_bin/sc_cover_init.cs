using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class sc_cover_init : MonoBehaviour
{
    public static int type; // 0: �����, 1: �ܻ��, 2: ����, 3: �ϻ��
    public static int position; // 0: Left, 1: Right
    public static int angle; // 10, 20, 25, 30, 35, 40, 45, 50

    public GameObject eye_L;
    public GameObject eye_R;


    public TMP_Text currentstatus;
    public TMP_Dropdown dropdown_position;
    public TMP_Dropdown dropdown_type;
    public TMP_Dropdown dropdown_angle;

    // �߰����� ���Ϸ���(��� �ܻ�� 20��)
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
        // ���� �ó����� ���� �ؽ�Ʈ�� �ð�ȭ
        currentstatus.text = "SEAH: " + position + " / " + type + " / " + angle;

        // ��� ���� �ʱ� �ȱ� ȸ�� ���� ����
        if (type == 0) // �����
        {
            if (position == 0) // �¾� �����
            {
                switch (angle)
                {
                    case 10: // �¾� ����� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        Debug.Log("�¾� ����� 10��");
                        break;
                    case 20: // �¾� ����� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        Debug.Log("�¾� ����� 20��");
                        break;
                    case 25: // �¾� ����� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        Debug.Log("�¾� ����� 25��");
                        break;
                    case 30: // �¾� ����� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        Debug.Log("�¾� ����� 30��");
                        break;
                    case 35: // �¾� ����� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        Debug.Log("�¾� ����� 35��");
                        break;
                    case 40: // �¾� ����� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        Debug.Log("�¾� ����� 40��");
                        break;
                    case 45: // �¾� ����� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        Debug.Log("�¾� ����� 45��");
                        break;
                    case 50: // �¾� ����� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        Debug.Log("�¾� ����� 50��");
                        break;
                }
            }

            if (position == 1) // ��� �����
            {
                switch (angle)
                {
                    case 10: // ��� ����� 10��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // ��� ����� 20��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // ��� ����� 25��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // ��� ����� 30��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // ��� ����� 35��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // ��� ����� 40��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // ��� ����� 45��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // ��� ����� 50��
                        eye_R.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }
        }

        
        if (type == 1) // �ܻ��
        {
            if (position == 0) // �¾� �ܻ��
            {
                switch (angle)
                {
                    case 10: // �¾� �ܻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -3, 0);
                        break;
                    case 20: // �¾� �ܻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -5, 0);
                        break;
                    case 25: // �¾� �ܻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -7, 0);
                        break;
                    case 30: // �¾� �ܻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -9, 0);
                        break;
                    case 35: // �¾� �ܻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -11, 0);
                        break;
                    case 40: // �¾� �ܻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -13, 0);
                        break;
                    case 45: // �¾� �ܻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -15, 0);
                        break;
                    case 50: // �¾� �ܻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(0, -17, 0);
                        break;
                }
            }

            if (position == 1) // ��� �ܻ��
            {
                switch (angle)
                {
                    case 10: // ��� �ܻ�� 10��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 3, 0);
                        break;
                    case 20: // ��� �ܻ�� 20��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 5, 0);
                        break;
                    case 25: // ��� �ܻ�� 25��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 7, 0);
                        break;
                    case 30: // ��� �ܻ�� 30��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 9, 0);
                        break;
                    case 35: // ��� �ܻ�� 35��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 11, 0);
                        break;
                    case 40: // ��� �ܻ�� 40��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 13, 0);
                        break;
                    case 45: // ��� �ܻ�� 45��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 15, 0);
                        break;
                    case 50: // ��� �ܻ�� 50��
                        eye_R.transform.localRotation = Quaternion.Euler(0, 17, 0);
                        break;
                }
            }
        }

        
        if (type == 2) // ����
        {
            if (position == 0) // �¾� ����
            {
                switch (angle)
                {
                    case 10: // �¾� ���� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // �¾� ���� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // �¾� ���� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // �¾� ���� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // �¾� ���� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // �¾� ���� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // �¾� ���� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // �¾� ���� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }

            if (position == 1) // ��� ����
            {
                switch (angle)
                {
                    case 10: // ��� ���� 10��
                        eye_R.transform.localRotation = Quaternion.Euler(-5, 0, 0);
                        break;
                    case 20: // ��� ���� 20��
                        eye_R.transform.localRotation = Quaternion.Euler(-7, 0, 0);
                        break;
                    case 25: // ��� ���� 25��
                        eye_R.transform.localRotation = Quaternion.Euler(-9, 0, 0);
                        break;
                    case 30: // ��� ���� 30��
                        eye_R.transform.localRotation = Quaternion.Euler(-11, 0, 0);
                        break;
                    case 35: // ��� ���� 35��
                        eye_R.transform.localRotation = Quaternion.Euler(-13, 0, 0);
                        break;
                    case 40: // ��� ���� 40��
                        eye_R.transform.localRotation = Quaternion.Euler(-15, 0, 0);
                        break;
                    case 45: // ��� ���� 45��
                        eye_R.transform.localRotation = Quaternion.Euler(-17, 0, 0);
                        break;
                    case 50: // ��� ���� 50��
                        eye_R.transform.localRotation = Quaternion.Euler(-19, 0, 0);
                        break;
                }
            }
        }


        if (type == 3) // �ϻ��
        {
            if (position == 0) // �¾� �ϻ��
            {
                switch (angle)
                {
                    case 10: // �¾� �ϻ�� 10��
                        eye_L.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // �¾� �ϻ�� 20��
                        eye_L.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // �¾� �ϻ�� 25��
                        eye_L.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // �¾� �ϻ�� 30��
                        eye_L.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // �¾� �ϻ�� 35��
                        eye_L.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // �¾� �ϻ�� 40��
                        eye_L.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // �¾� �ϻ�� 45��
                        eye_L.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // �¾� �ϻ�� 50��
                        eye_L.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }

            if (position == 1) // ��� �ϻ��
            {
                switch (angle)
                {
                    case 10: // ��� �ϻ�� 10��
                        eye_R.transform.localRotation = Quaternion.Euler(5, 0, 0);
                        break;
                    case 20: // ��� �ϻ�� 20��
                        eye_R.transform.localRotation = Quaternion.Euler(7, 0, 0);
                        break;
                    case 25: // ��� �ϻ�� 25��
                        eye_R.transform.localRotation = Quaternion.Euler(9, 0, 0);
                        break;
                    case 30: // ��� �ϻ�� 30��
                        eye_R.transform.localRotation = Quaternion.Euler(11, 0, 0);
                        break;
                    case 35: // ��� �ϻ�� 35��
                        eye_R.transform.localRotation = Quaternion.Euler(13, 0, 0);
                        break;
                    case 40: // ��� �ϻ�� 40��
                        eye_R.transform.localRotation = Quaternion.Euler(15, 0, 0);
                        break;
                    case 45: // ��� �ϻ�� 45��
                        eye_R.transform.localRotation = Quaternion.Euler(17, 0, 0);
                        break;
                    case 50: // ��� �ϻ�� 50��
                        eye_R.transform.localRotation = Quaternion.Euler(19, 0, 0);
                        break;
                }
            }
        }
    }

    
    // �ó����� ����(btn)
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
