using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    public AudioClip swordSound;

    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }


    private void OnCollisionEnter(Collision collision)
    {
        audio.pitch = Random.Range(0.7f, 1.3f);
        audio.PlayOneShot(swordSound);

        Score.Instance.Fruits++;
        //Destroy(collision.gameObject);
    }
}
