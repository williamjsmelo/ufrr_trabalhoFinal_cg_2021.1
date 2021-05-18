using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectCoin : MonoBehaviour
{
    public int coinVault = 0;
    public Text score;
    public GameObject innerKey;
    private int coinTotal;

    private void Awake(){
        coinTotal = GameObject.FindGameObjectsWithTag("Coin").Length;
    }

    private void OnCollisionEnter(Collision objeto){
        if(objeto.gameObject.CompareTag("Coin")){
            //Destroy(objeto.gameObject);
            objeto.gameObject.SetActive(false);
            coinVault += 1;
            print(coinVault);
            score.text = "Score: " + coinVault.ToString();
            GetComponent<AudioSource>().Play();

            if(coinVault == coinTotal){
                innerKey.gameObject.SetActive(true);
            }
        }
    }
}
