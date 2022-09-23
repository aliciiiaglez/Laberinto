using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorColisionPared : MonoBehaviour
{
    [SerializeField]
    Material materialPorDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredrosa = false;

    float tiempoEnRosa = tiempoEnRosa;
    //funcion que se ejecuta por cada imagen del juego
    private void Update()
    {
        if (paredrosa == true)
            
                }
    //funcion que se ejecute al chocar un objeto con este GameObject
    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player") 
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
        }
    }
}
