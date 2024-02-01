using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour
{
    public Transform cursor;

    private Camera mainCamera;
    private bool isTouching;

    private void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isTouching = true;
            cursor.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isTouching = false;
            cursor.gameObject.SetActive(false);
        }

        if (isTouching)
        {
            var mousePosition = Input.mousePosition;
            mousePosition.z = -mainCamera.transform.position.z;

            var worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

            cursor.position = worldPosition;
        }

    }
}
