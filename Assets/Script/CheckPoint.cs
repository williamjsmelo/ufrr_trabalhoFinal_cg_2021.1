using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Text winText;

    private void OnCollisionEnter(Collision jogador){
        if(jogador.gameObject.CompareTag("Player")){
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;
            winText.gameObject.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
    }
}
