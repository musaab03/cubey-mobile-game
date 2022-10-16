using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    //Ints and Floats
    public int coins;
    public int levelNumber;
    public int lives;


    void Awake()
    {
        coins = PlayerPrefs.GetInt("Coins");
        levelNumber = PlayerPrefs.GetInt("LevelNumber");
        PlayerPrefs.SetInt("Lives", 10);
        lives = PlayerPrefs.GetInt("Lives");
    }
}
