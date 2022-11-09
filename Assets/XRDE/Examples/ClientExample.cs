// Copyright ETRI(Electronics and Telecommunications Research Institute).
// Licensed under the MIT License.

using UnityEngine;

public class ClientExample : MonoBehaviour
{
    private void Awake()
    {
        XRDE.DataExtractorManager.SceneIndex = "S1_101";
    }

    public void UpdateSceneIndex()
    {
        int sceneIndex;
        if (int.TryParse(XRDE.DataExtractorManager.SceneIndex.Substring(3), out sceneIndex))
        {
            sceneIndex++;
        }

        XRDE.DataExtractorManager.SceneIndex = XRDE.DataExtractorManager.SceneIndex.Substring(0, 3) + sceneIndex.ToString();

        Debug.Log(XRDE.DataExtractorManager.SceneIndex);
    }
}
