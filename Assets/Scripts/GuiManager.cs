using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GuiManager : MonoBehaviour {

    //Components
    [SerializeField] GameManager gm;

    void Start()
    {
        gm = gm.GetComponent<GameManager>();
    }

    public void NextLevel()
    {
        if (gm.levelNumber == SceneManager.GetActiveScene().buildIndex & gm.levelNumber < 50)
        {
            SceneManager.LoadScene(gm.levelNumber + 1);
        }
    }

    public void Return()
    {
        SceneManager.LoadScene(0);
    }
}
