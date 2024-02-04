using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    private AudioSource audio;

    public AudioClip slashSound;

    
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    


    private void OnCollisionEnter(Collision collision){

        audio.PlayOneShot(slashSound);

        ScoreCounter.Instance.Fruits++;

        Destroy(collision.gameObject); 
    }
}
