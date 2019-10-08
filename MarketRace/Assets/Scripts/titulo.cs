using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class titulo : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;

    public int acabado = 0;

    public GameObject playerNaranja;
    public GameObject playerVerde;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprite1;
    }

    // Update is called once per frame
    void Update()
    {
        if (acabado==1)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("menu");
            }
        }
    }

    public void ganaNaranja()
    {
        spriteRenderer.sprite = sprite2;
        Vector3 vector = new Vector3(27.3f, 7.49f, 0f);
        playerNaranja.transform.position = vector;
        playerVerde.transform.position = vector;
        acabado = 1;
    }

    public void ganaVerde()
    {
        spriteRenderer.sprite = sprite3;
        Vector3 vector = new Vector3(27.3f, 7.49f, 0f);
        playerNaranja.transform.position = vector;
        playerVerde.transform.position = vector;
        acabado = 1;
    }
    
}
