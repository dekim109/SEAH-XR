using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sc_update_sceneindex : MonoBehaviour
{
    public GameObject stick;
    public GameObject occluder;
    public GameObject prism;

    public GameObject canvas;

    public GameObject sctbox;

    Scene current_scene;
    string scenename;

    public void UpdateSceneIndex()
    {
        current_scene = SceneManager.GetActiveScene();
        scenename = current_scene.name;

        if (scenename == "S1_111")
        {
            XRDE.DataExtractorManager.SceneIndex = "S1_111";
            XRDE.DataExtractorManager.MainInteractingObject = stick;

            /*/
            sctbox.GetComponent<sc_stick_data>().enabled = true;
            sctbox.GetComponent<sc_cover_init>().enabled = false;
            sctbox.GetComponent<sc_cover_data>().enabled = false;

            canvas.SetActive(false);
            /*/
        }

        if (scenename == "S1_121")
        {
            XRDE.DataExtractorManager.SceneIndex = "S1_121";
            XRDE.DataExtractorManager.MainInteractingObject = occluder;

            /*/
            sctbox.GetComponent<sc_stick_data>().enabled = false;
            sctbox.GetComponent<sc_cover_init>().enabled = true;
            sctbox.GetComponent<sc_cover_data>().enabled = true;

            canvas.SetActive(true);
            /*/
        }
    }
}
