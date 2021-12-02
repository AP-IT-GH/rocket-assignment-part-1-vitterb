using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    private Health healthPlayer;
    public enum Gamestates
    {
        Playing,
        GameOver
    }

    public Gamestates gameState = Gamestates.Playing;

    // Start is called before the first frame update
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        healthPlayer = Player.GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case Gamestates.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = Gamestates.GameOver;
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                }
                break;
        }
    }
}
