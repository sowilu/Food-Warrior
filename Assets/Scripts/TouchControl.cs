using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    public Transform cursor;
    public bool finger_down;
    private Camera main;
    // Start is called before the first frame update
    void Start()
    {
        main = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            finger_down = true;
            cursor.gameObject.SetActive(true);
        }
        else if (Input.GetMouseButtonUp(0)){
            finger_down = false;
            cursor.gameObject.SetActive(false);
        }

        if(finger_down){
            var mousePosition = Input.mousePosition;
            mousePosition.z = -main.transform.position.z;
            var position = main.ScreenToWorldPoint(mousePosition);
            cursor.position = position;
        }
        
    }
}
