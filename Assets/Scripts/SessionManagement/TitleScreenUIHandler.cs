using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor;
#endif

[DefaultExecutionOrder(10000)]
public class TitleScreenUIHandler : MonoBehaviour
{
    string FightSceneName = "FightScene";

    public Image ColorIcon;

    public void LoadFightScene()
    {
        SceneManager.LoadScene(FightSceneName);
    }

    public void LoadData()
    {
        GameManager.Instance.LoadColor();
        ColorIcon.color = GameManager.Instance.PlayerColor;
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
