using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public Color PlayerColor;

    private void Awake()
    {
        InstantiateGameManager();
        LoadColor();
    }

    void InstantiateGameManager()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadColor()
    {
        PlayerColor = Color.cyan;
    }


}
