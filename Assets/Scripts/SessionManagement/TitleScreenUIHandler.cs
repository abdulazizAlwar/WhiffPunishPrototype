using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(10000)]
public class TitleScreenUIHandler : MonoBehaviour
{
    string FightSceneName = "FightScene";

    public void LoadFightScene()
    {
        SceneManager.LoadScene(FightSceneName);
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else   
        Application.Quit();
        #endif
    }
}
