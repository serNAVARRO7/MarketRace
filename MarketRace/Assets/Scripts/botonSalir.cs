using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botonSalir : MonoBehaviour
{
    public GameObject botone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        botone.GetComponent<botones>().salir();
    }
}
