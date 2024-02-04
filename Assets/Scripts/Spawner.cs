using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Sounds")]
    public AudioClip fruitClip;

    private AudioSource sound;
    public List<GameObject> fruits;

    public float throwForce = 100;


    void Start()
    {
        sound = GetComponent<AudioSource>(); 
       StartCoroutine(ThrowFruit());
    }


    IEnumerator ThrowFruit(){

        while (true){

            var randomFruit = fruits[Random.Range(0, fruits.Count)];
            
            var fruit = Instantiate(randomFruit, transform.position, Quaternion.identity);
            Destroy(fruit, 5);

            var randomAngle = Vector3.right * Random.Range(-0.3f, 0.3f);
            fruit.GetComponent<Rigidbody>().AddForce((Vector3.up + randomAngle) * throwForce);

            sound.pitch = Random.Range(0.9f, 1.2f);
            sound.PlayOneShot(fruitClip);
            yield return new WaitForSeconds(3);

        }
    }



}
