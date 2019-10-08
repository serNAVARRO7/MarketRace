using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoPlayerNaranja : MonoBehaviour
{
    // En esta variable configuraremos la velocidad a la que se moverá el objeto
    public float Velocidad = 5.0F;
    private int ultimoMovimiento = 1;

    private SpriteRenderer spriteRenderer;
    public Sprite sprite1; 
    public Sprite sprite2; 
    public Sprite sprite3; 
    public Sprite sprite4;

    public GameObject casilla1;
    public GameObject casilla2;
    public GameObject casilla3;
    public GameObject casilla4;

    public GameObject objeto;
    public GameObject otroJugador;
    public GameObject titulo;
    public GameObject cono;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            ultimoMovimiento = 1;
            spriteRenderer.sprite = sprite1;
            this.transform.Translate(Vector3.up * Time.deltaTime * Velocidad);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            ultimoMovimiento = 2;
            spriteRenderer.sprite = sprite2;
            this.transform.Translate(Vector3.down * Time.deltaTime * Velocidad);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            ultimoMovimiento = 3;
            spriteRenderer.sprite = sprite3;
            this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            ultimoMovimiento = 4;
            spriteRenderer.sprite = sprite4;
            this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            usarObjeto();
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "colliderSupermercado")
        {
            if (ultimoMovimiento == 1)
            {
                Down();
            }
            if (ultimoMovimiento == 2)
            {
                Up();
            }
            if (ultimoMovimiento == 3)
            {
                Right();
            }
            if (ultimoMovimiento == 4)
            {
                Left();
            }
        }
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        int numeroAlimentoCasilla1 = casilla1.GetComponent<casilla>().getNumeroAlimento();
        int numeroAlimentoCasilla2 = casilla2.GetComponent<casilla>().getNumeroAlimento();
        int numeroAlimentoCasilla3 = casilla3.GetComponent<casilla>().getNumeroAlimento();
        int numeroAlimentoCasilla4 = casilla4.GetComponent<casilla>().getNumeroAlimento();
        int numeroAlimentoRecoger=0;
        if (collision.gameObject.tag == "colliderCaja" && numeroAlimentoCasilla1==-2 && numeroAlimentoCasilla2 == -2 && numeroAlimentoCasilla3 == -2 && numeroAlimentoCasilla4 == -2)
        {
            titulo.GetComponent<titulo>().ganaNaranja();
        }
        if (collision.gameObject.tag == "colliderAlimento1")
            {
            numeroAlimentoRecoger = 1;
            }
            if (collision.gameObject.tag == "colliderAlimento2")
            {
            numeroAlimentoRecoger = 2;
        }
            if (collision.gameObject.tag == "colliderAlimento3")
            {
            numeroAlimentoRecoger = 3;
        }
            if (collision.gameObject.tag == "colliderAlimento4")
            {
            numeroAlimentoRecoger = 4;
        }
            if (collision.gameObject.tag == "colliderAlimento5")
            {
            numeroAlimentoRecoger = 5;
        }
            if (collision.gameObject.tag == "colliderAlimento6")
            {
            numeroAlimentoRecoger = 6;
        }
            if (collision.gameObject.tag == "colliderAlimento7")
            {
            numeroAlimentoRecoger = 7;
        }
            if (collision.gameObject.tag == "colliderAlimento8")
            {
            numeroAlimentoRecoger = 8;
        }
            if (collision.gameObject.tag == "colliderAlimento9")
            {
            numeroAlimentoRecoger = 9;
        }
            if (collision.gameObject.tag == "colliderAlimento10")
            {
            numeroAlimentoRecoger = 10;
        }
            if (collision.gameObject.tag == "colliderAlimento11")
            {
            numeroAlimentoRecoger = 11;
        }
            if (collision.gameObject.tag == "colliderAlimento12")
            {
            numeroAlimentoRecoger = 12;
        }
            if (collision.gameObject.tag == "colliderAlimento13")
            {
            numeroAlimentoRecoger = 13;
        }
            if (collision.gameObject.tag == "colliderAlimento14")
            {
            numeroAlimentoRecoger = 14;
        }
            if (collision.gameObject.tag == "colliderAlimento15")
            {
            numeroAlimentoRecoger = 15;
        }
            if (collision.gameObject.tag == "colliderAlimento16")
            {
            numeroAlimentoRecoger = 16;
        }
            if (collision.gameObject.tag == "colliderAlimento17")
            {
            numeroAlimentoRecoger = 17;
        }
            if (collision.gameObject.tag == "colliderAlimento18")
            {
            numeroAlimentoRecoger = 18;
        }
            if (collision.gameObject.tag == "colliderAlimento19")
            {
            numeroAlimentoRecoger = 19;
        }
            if (collision.gameObject.tag == "colliderAlimento20")
            {
            numeroAlimentoRecoger = 20;
        }
            if (collision.gameObject.tag == "colliderAlimento21")
            {
            numeroAlimentoRecoger = 21;
        }
            if (collision.gameObject.tag == "colliderAlimento22")
            {
            numeroAlimentoRecoger = 22;
        }
            if (collision.gameObject.tag == "colliderAlimento23")
            {
            numeroAlimentoRecoger = 23;
        }
            if (collision.gameObject.tag == "colliderAlimento24")
            {
            numeroAlimentoRecoger = 24; 
        }
        if (numeroAlimentoRecoger!=0)
        {
            if (Input.GetKeyDown(KeyCode.H))
            {
                if (numeroAlimentoCasilla1==numeroAlimentoRecoger)
                {
                    casilla1.GetComponent<casilla>().recogidoAlimento();
                    objeto.GetComponent<objeto>().darObjeto();
                }
                else if (numeroAlimentoCasilla2 == numeroAlimentoRecoger)
                {
                    casilla2.GetComponent<casilla>().recogidoAlimento();
                    objeto.GetComponent<objeto>().darObjeto();
                }
                else if (numeroAlimentoCasilla3 == numeroAlimentoRecoger)
                {
                    casilla3.GetComponent<casilla>().recogidoAlimento();
                    objeto.GetComponent<objeto>().darObjeto();
                }
                else if (numeroAlimentoCasilla4 == numeroAlimentoRecoger)
                {
                    casilla4.GetComponent<casilla>().recogidoAlimento();
                    objeto.GetComponent<objeto>().darObjeto();
                }
            }
        }
    }

    void Up()
    {
        spriteRenderer.sprite = sprite1;
        this.transform.Translate(Vector3.up * Time.deltaTime * Velocidad);

    }
    void Down()
    {
        spriteRenderer.sprite = sprite2;
        this.transform.Translate(Vector3.down * Time.deltaTime * Velocidad);
    }
    void Left()
    {
        spriteRenderer.sprite = sprite3;
        this.transform.Translate(Vector3.left * Time.deltaTime * Velocidad);
    }
    void Right()
    {
        spriteRenderer.sprite = sprite4;
        this.transform.Translate(Vector3.right * Time.deltaTime * Velocidad);
    }

    public void setVelocidad(float pVelocidad)
    {
        Velocidad = pVelocidad;
    }

    public void usarObjeto()
    {
        int actual = objeto.GetComponent<objeto>().getObjetoActual();
        if (actual == 2)
        {
            setVelocidad(28);
        }
        if (actual != 2)
        {
            setVelocidad(18);
        }
        if (actual == 1)
        {
            otroJugador.GetComponent<movimientoPlayerVerde>().setVelocidad(9);
        }
        if (actual==3)
        {
            Vector3 vector = new Vector3(7.09f, -4.25f, -2f);
            otroJugador.transform.position = vector;
        }
        if (actual==4)
        {
            moverCono();
        }
        objeto.GetComponent<objeto>().usadoObjeto();
    }

    void moverCono()
    {
        float lax = this.transform.position.x;
        float lay = this.transform.position.y;
        if (ultimoMovimiento == 1)
        {
            Up();
            Up();
        }
        if (ultimoMovimiento == 2)
        {
            Down();
            Down();
        }
        if (ultimoMovimiento == 3)
        {
            Left();
            Left();
        }
        if (ultimoMovimiento == 4)
        {
            Right();
            Right();
        }
        Vector3 vectorpos = new Vector3(lax, lay, -2f);
        cono.transform.position = vectorpos;
    }
}

