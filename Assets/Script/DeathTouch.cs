using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class DeathTouch : MonoBehaviour
{
    public Text gameOverText;

    private void OnCollisionEnter(Collision jogador){
        if(jogador.gameObject.CompareTag("Player")){
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;
            gameOverText.gameObject.SetActive(true);
            GetComponent<AudioSource>().Play();
        }
    }
}
