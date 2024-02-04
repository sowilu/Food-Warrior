using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100;

    private Vector3 direction;

    private void Start()
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
