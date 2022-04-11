using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour {

    //Components
    [SerializeField] GameManager gm;
    [SerializeField] GuiManager guim;

    void Start()
    {
        gm = gm.GetComponent<GameManager>();
        guim = guim.GetComponent<GuiManager>();
    }

    void Update()
    {
        if(gm.lives <= 0)
        {
            PlayerPrefs.SetInt("LevelNumber", 0);

        }
    }
}
