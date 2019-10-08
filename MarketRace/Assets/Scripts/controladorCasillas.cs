using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorCasillas : MonoBehaviour
{
    public int alimento1;
    public int alimento2;
    public int alimento3;
    public int alimento4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        alimento1 = asignaNumero();
        alimento2 = asignaNumero();
        alimento3 = asignaNumero();
        alimento4 = asignaNumero();
        print(alimento1 + " " + alimento2 + " " + alimento3 + " " + alimento4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int asignaNumero()
    {
        int numero = Random.Range(1, 25);
        if (numero!=alimento1 && numero != alimento2 && numero != alimento3 && numero != alimento4)
        {
            return numero;
        }
        else 
        {
            numero = Random.Range(1, 25);
            return numero;
        }       
    }

    public int getAlimento1()
    {
        return alimento1;
    }
    public int getAlimento2()
    {
        return alimento2;
    }
    public int getAlimento3()
    {
        return alimento3;
    }
    public int getAlimento4()
    {
        return alimento4;
    }

    public int getAlimento(int pAlimento)
    {
        print("getalimento");
        if (pAlimento == 1)
        {
            return alimento1;
        }
        else if (pAlimento == 2)
        {
            return alimento2;
        }
        else if (pAlimento == 3)
        {
            return alimento3;
        }
        else if (pAlimento == 4)
        {
            return alimento4;
        }
        return -1;
    }
}
