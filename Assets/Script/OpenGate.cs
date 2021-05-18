using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{
    public GameObject gate;

    private void OnCollisionEnter(Collision jogador){
        if(jogador.gameObject.CompareTag("Player")){
            //Destroy(gate.gameObject);
            //Destroy(this.gameObject);
            gate.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
