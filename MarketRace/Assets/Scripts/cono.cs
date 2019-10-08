using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cono : MonoBehaviour
{
    public int choques=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (choques==10)
        {
            Vector3 vector = new Vector3(27.3f, 7.49f, -2f);
            this.transform.position = vector;
            choques = 0;
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        choques++;
        print("choques" + choques);
    }
}
