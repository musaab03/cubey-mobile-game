using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour {

    //Components
    public GameManager gm;
    public GameObject plusOneText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            gm.coins += 1;
            PlayerPrefs.SetInt("Coins", gm.coins);
            Destroy(other.gameObject);
            StartCoroutine(PlusOneText());
        }
    }

    IEnumerator PlusOneText()
    {
        plusOneText.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.6f);
        plusOneText.gameObject.SetActive(false);
    }
}
