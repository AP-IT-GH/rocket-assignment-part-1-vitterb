using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntToString : MonoBehaviour
{

    public GameObject Player;
    private Health healthPlayer;
    public float lives;
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
        healthPlayer = Player.GetComponent<Health>();
        lives = healthPlayer.healthPoints;
        text.text = lives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(Player != null){
            lives = healthPlayer.healthPoints;
            text.text = lives.ToString();
        }
        
    }
}
