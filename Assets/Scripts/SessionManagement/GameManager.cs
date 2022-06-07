using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private Color prv_PlayerColor;
    public Color PlayerColor
    {
        // ENCAPSULATION
        get { return prv_PlayerColor; }
        private set
        {
            if (value == Color.clear)
            {
                print("Can't use this color");
            }
            else
            {
                prv_PlayerColor = value;
            }
        }
    }

    private void Awake()
    {
        InstantiateGameManager();
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
