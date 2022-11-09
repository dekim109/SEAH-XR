using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc_scenemanager_init : MonoBehaviour
{
    public float scene_num;

    void Start()
    {
        if (scene_num == 1)
        {
            Invoke("load_1", 10f);
        }

        if (scene_num == 2)
        {
            Invoke("load_2", 10f);
        }

        if (scene_num == 3)
        {
            Invoke("load_3", 10f);
        }
    }

    void load_1()
    {
        SceneManager.LoadScene("S1_111");
    }

    void load_2()
    {
        SceneManager.LoadScene("S1_121");
    }

    void load_3()
    {
        SceneManager.LoadScene("S1_131");
    }
}
