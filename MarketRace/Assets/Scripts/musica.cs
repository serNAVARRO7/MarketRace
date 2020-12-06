using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    AudioSource fuenteAudio;
    public AudioClip cashRegister;
    public AudioClip silbato;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
        //DontDestroyOnLoad(this.gameObject);
        //fuenteAudio.clip = cashRegister;
    }
    // Update is called once per frame
    void Update()
    {

    }

    public void cashRegisterSound()
    {
        fuenteAudio.clip = cashRegister;
        fuenteAudio.Play();
    }

    public void silbatoSound()
    {
        fuenteAudio.clip = silbato;
        fuenteAudio.Play();
    }
}
