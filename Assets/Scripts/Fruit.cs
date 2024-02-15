using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public Color juicesColor;
    public GameObject juicesVfx;
    public AudioClip slashSound;

    private void OnCollisionEnter(Collision collision)
    {
        //todo: if fruits collide with each other check if sword
        GetComponent<Collider>().enabled = false;
        GetComponent<TrailRenderer>().enabled = false;

        //spawn juices
        var juices = Instantiate(juicesVfx, transform.position, Quaternion.identity);
        var main = juices.GetComponent<ParticleSystem>().main;
        main.startColor = juicesColor;

        //play splash sound
        AudioManager.instance.Play(slashSound);

        //spawn splash
        Splasher.instance.SpawnSplash(juicesColor, transform.position + Vector3.forward * 2);

        var dir = Vector3.right;
        foreach(Transform child in transform)
        {
            child.parent = null;
            Destroy(child.gameObject, 3);
            var rb = child.gameObject.AddComponent<Rigidbody>();
            rb.AddForce(dir * Random.Range(50, 100));
            dir *= -1;
        }

        
    }
}
