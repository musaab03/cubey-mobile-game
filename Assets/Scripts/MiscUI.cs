using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MiscUI : MonoBehaviour {

    //Components
    [SerializeField] GameManager gm;

    public Text coinText;
    public Text livesText;

    private void Start()
    {
        gm = gm.GetComponent<GameManager>();
    }

    void Update ()
    {
        coinText.text = "Coins: " + gm.coins.ToString();
        livesText.text = "Lives: " + gm.lives.ToString();
	}
}
