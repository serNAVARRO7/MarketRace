using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class casilla : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4; public Sprite sprite15;
    public Sprite sprite5; public Sprite sprite16;
    public Sprite sprite6; public Sprite sprite17;
    public Sprite sprite7; public Sprite sprite18;
    public Sprite sprite8; public Sprite sprite19;
    public Sprite sprite9; public Sprite sprite20;
    public Sprite sprite10; public Sprite sprite21;
    public Sprite sprite11; public Sprite sprite22;
    public Sprite sprite12; public Sprite sprite23;
    public Sprite sprite13; public Sprite sprite24;
    public Sprite sprite14;
    public Sprite recogido;

    private int numeroCasilla=0;
    public int numeroAlimento=0;
    public GameObject controlador;

    // Start is called before the first frame update
    void Start()
    {
        if (this.name=="naranja1"|| this.name == "verde1")
        {
            numeroCasilla = 1;
        }
        else if (this.name == "naranja2" || this.name == "verde2")
        {
            numeroCasilla = 2;
        }
        else if (this.name == "naranja3" || this.name == "verde3")
        {
            numeroCasilla = 3;
        }
        else if (this.name == "naranja4" || this.name == "verde4")
        {
            numeroCasilla = 4;
        }
        spriteRenderer = GetComponent<SpriteRenderer>();
        //Thread.Sleep(2000);
        numeroAlimento = controlador.GetComponent<controladorCasillas>().getAlimento(numeroCasilla);
        setSprite(numeroAlimento);
        print(numeroAlimento);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void setSprite(int pNumero)
    {
        if (pNumero == 1)
        {
            spriteRenderer.sprite = sprite1;
        }
        if (pNumero == 2)
        {
            spriteRenderer.sprite = sprite2;
        }
        if (pNumero == 3)
        {
            spriteRenderer.sprite = sprite3;
        }
        if (pNumero == 4)
        {
            spriteRenderer.sprite = sprite4;
        }
        if (pNumero == 5)
        {
            spriteRenderer.sprite = sprite5;
        }
        if (pNumero == 6)
        {
            spriteRenderer.sprite = sprite6;
        }
        if (pNumero == 7)
        {
            spriteRenderer.sprite = sprite7;
        }
        if (pNumero == 8)
        {
            spriteRenderer.sprite = sprite8;
        }
        if (pNumero == 9)
        {
            spriteRenderer.sprite = sprite9;
        }
        if (pNumero == 10)
        {
            spriteRenderer.sprite = sprite10;
        }
        if (pNumero == 11)
        {
            spriteRenderer.sprite = sprite11;
        }
        if (pNumero == 12)
        {
            spriteRenderer.sprite = sprite12;
        }
        if (pNumero == 13)
        {
            spriteRenderer.sprite = sprite13;
        }
        if (pNumero == 14)
        {
            spriteRenderer.sprite = sprite14;
        }
            if (pNumero == 15)
            {
                spriteRenderer.sprite = sprite15;
            }
            if (pNumero == 16)
            {
                spriteRenderer.sprite = sprite16;
            }
            if (pNumero == 17)
            {
                spriteRenderer.sprite = sprite17;
            }
            if (pNumero == 18)
            {
                spriteRenderer.sprite = sprite18;
            }
            if (pNumero == 19)
            {
                spriteRenderer.sprite = sprite19;
            }
            if (pNumero == 20)
            {
                spriteRenderer.sprite = sprite20;
            }
            if (pNumero == 21)
            {
                spriteRenderer.sprite = sprite21;
            }
            if (pNumero == 22)
            {
                spriteRenderer.sprite = sprite22;
            }
            if (pNumero == 23)
            {
                spriteRenderer.sprite = sprite23;
            }
            if (pNumero == 24)
            {
                spriteRenderer.sprite = sprite24;
            }
        
    }

    public void recogidoAlimento()
    {
        spriteRenderer.sprite = recogido;
        numeroAlimento = -2;
    }

    public int getNumeroAlimento()
    {
        return numeroAlimento;
    }
}
