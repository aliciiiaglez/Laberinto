using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorColisionp : MonoBehaviour
{
    //Marcamos los materiales
    [SerializeField]
    Material materialParedDefecto;

    [SerializeField]
    Material materialParedTocada;

    bool paredRosa = false;
    
    float timeRosa = 5f; 

    private void Update()
    {
        if(paredRosa == true)
        {
            timeRosa = timeRosa - Time.deltaTime;
            if (timeRosa < 0.0f)
            {
                gameObject.GetComponent<MeshRenderer>().material = materialParedDefecto;
                paredRosa = false;
                timeRosa = 5f;

            }
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Player")
        {
            Debug.Log(col.gameObject.name);
            gameObject.GetComponent<MeshRenderer>().material = materialParedTocada;
            paredRosa = true; 
        }

        
    }
}
