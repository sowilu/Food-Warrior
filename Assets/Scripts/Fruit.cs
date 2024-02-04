using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        //todo: if fruits collide with each other check if sword
        GetComponent<Collider>().enabled = false;

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
