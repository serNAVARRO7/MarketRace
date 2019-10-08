using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objeto : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite0;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;

    //0 nada; 1 invisible; 2 velocidad;3 meta
    int actual = 0;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        actualizarObjeto();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void darObjeto()
    {
        actual = Random.Range(1, 5);
        actualizarObjeto();
    }

    public int getObjetoActual()
    {
        return actual;
    }

    public void usadoObjeto()
    {
        actual = 0;
        actualizarObjeto();
    }

    public void actualizarObjeto()
    {
        if (actual==0)
        {
            spriteRenderer.sprite = sprite0;
        }
        if (actual == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        if (actual == 2)
        {
            spriteRenderer.sprite = sprite2;
        }
        if (actual == 3)
        {
            spriteRenderer.sprite = sprite3;
        }
        if (actual==4)
        {
            spriteRenderer.sprite = sprite4;
        }
    }
}
