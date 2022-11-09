using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public static int SceneNum;
    public GameObject[] SceneObj;

    void Start()
    {
        CoverInit.position = 1;
        CoverInit.angle = 20;
    }

    public void LoadScene1() // Ocular Motility Test - ��
    {
        SceneNum = 1;

        SceneObj[0].SetActive(true);
        SceneObj[1].SetActive(false);
        SceneObj[2].SetActive(false);

        XRDE.DataExtractorManager.SceneIndex = "S1_111";
    }

    public void LoadScene2() // Cover Uncover Test - ��
    {
        SceneNum = 2;
        CoverInit.type = 0;

        SceneObj[0].SetActive(false);
        SceneObj[1].SetActive(true);
        SceneObj[2].SetActive(false);

        XRDE.DataExtractorManager.SceneIndex = "S1_121";

        // Cover Test�� CoverInit.LoadCoverInit �߰� �ʿ�
    }

    public void LoadScene3() // Prism Cover Test - ��
    {
        SceneNum = 3;
        CoverInit.type = 0;

        SceneObj[0].SetActive(false);
        SceneObj[1].SetActive(false);
        SceneObj[2].SetActive(true);

        XRDE.DataExtractorManager.SceneIndex = "S1_131";
    }

    public void LoadScene4() // Ocular Motility Test - ��
    {
        SceneNum = 4;

        SceneObj[0].SetActive(true);
        SceneObj[1].SetActive(false);
        SceneObj[2].SetActive(false);

        XRDE.DataExtractorManager.SceneIndex = "S1_112";
    }

    public void LoadScene5() // Cover Uncover Test - ��
    {
        SceneNum = 5;
        CoverInit.type = 1;

        SceneObj[0].SetActive(false);
        SceneObj[1].SetActive(true);
        SceneObj[2].SetActive(false);

        XRDE.DataExtractorManager.SceneIndex = "S1_122";

        // Cover Test�� CoverInit.LoadCoverInit �߰� �ʿ�
    }

    public void LoadScene6() // Prism Cover Test - ��
    {
        SceneNum = 6;
        CoverInit.type = 1;

        SceneObj[0].SetActive(false);
        SceneObj[1].SetActive(false);
        SceneObj[2].SetActive(true);

        XRDE.DataExtractorManager.SceneIndex = "S1_132";
    }
}
