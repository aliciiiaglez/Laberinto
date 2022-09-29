using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
        [SerializeField]
        float rotacionX = 30f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-rotacionX* Time.deltaTime, 0.0f , 0.0f);
    }
       

        
    }
