using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour {

    int levelNumber;

    void Awake()
    {
        levelNumber = PlayerPrefs.GetInt("LevelNumber");
    }

    public void Play()
    {
        if (levelNumber == 0)
            SceneManager.LoadScene(1);
        else if (levelNumber == 1)
            SceneManager.LoadScene(2);
        else if (levelNumber > 1)
            SceneManager.LoadScene(levelNumber + 1);
    }

    public void Reset()
    {
        levelNumber = 0;
    }
}
