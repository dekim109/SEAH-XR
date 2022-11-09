using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc_scenemanager : SingletonBehaviour<sc_scenemanager>
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("S1_111");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("S1_121");
    }

    public void LoadScene3()
    {
        SceneManager.LoadScene("S1_131");
    }
}
