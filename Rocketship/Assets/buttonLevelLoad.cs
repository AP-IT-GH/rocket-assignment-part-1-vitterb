using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonLevelLoad : MonoBehaviour
{
    public string LevelToLoad;

    public void LevelLoad()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
