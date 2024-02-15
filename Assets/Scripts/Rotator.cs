using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 50;

    private Vector3 direction;

    void Start()
    {
        direction = new();
        direction.x = Random.Range(-1f, 1.1f);
        direction.y = Random.Range(-1f, 1.1f);
        direction.z = Random.Range(-1f, 1.1f);
    }

    
    void Update()
    {
        transform.Rotate(direction * speed * Time.deltaTime);
    }
}
