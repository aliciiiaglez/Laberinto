using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movjugador : MonoBehaviour
{
    public float movimientoEjeX;
    public float movimientoEjeY;
    public float movimientoEjeZ;
    // Start is called before the first frame update
    void Start()
    {
        
        transform.Translate(2.5f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        movimientoEjeZ = Input.GetAxis("Horizontal") * Time.deltaTime;
        movimientoEjeX = Input.GetAxis("Vertical") * Time.deltaTime;
        transform.Translate(movimientoEjeX, movimientoEjeY, movimientoEjeZ);  
    }
}
