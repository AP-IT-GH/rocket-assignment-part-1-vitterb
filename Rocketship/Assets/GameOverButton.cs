using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour
{
    public int levelSelect;

    public void LevelSelector()
    {
        SceneManager.LoadScene(levelSelect);
    }
   
}
