﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botones : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void irSupermercado()
    {
        SceneManager.LoadScene("supermercado");
    }

    public void salir()
    {
        Application.Quit();
    }
}
