using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class metaDetector : MonoBehaviour
{   
    [SerializeField]
    GameObject pantallaFinal;


    float tiempoDePartida = 0.0f;
    bool estaJugando = true;

    private void Update()
    {
        if (estaJugando == true)
        {
            tiempoDePartida = tiempoDePartida + Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Jugador llegó a la meta");
           pantallaFinal.SetActive(true);
            other.GetComponent<movimientoJugador>().enabled = false;
            estaJugando = false;
            Debug.Log(tiempoDePartida);
        }
    }
}
