using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour {

    [SerializeField] GameManager gm;
    [SerializeField] GuiManager uim;

    void Start()
    {
        gm = gm.GetComponent<GameManager>();
        uim = uim.GetComponent<GuiManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("Completed Level");
            PlayerPrefs.SetInt("LevelNumber", gm.levelNumber += 1);
            GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
