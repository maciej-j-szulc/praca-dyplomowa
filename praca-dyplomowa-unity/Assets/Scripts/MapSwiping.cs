using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSwiping : MonoBehaviour
{
    private Touch initTouch = new Touch();
    public Camera cam;

    private float rotZ = 0f;

    public float rotSpeed = 0.5f;

    void Start()
    {
        rotZ = cam.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Began)
            {
                initTouch = touch;
            }
            else if(touch.phase == TouchPhase.Moved)
            {
                float deltaX = initTouch.position.x - touch.position.x;
                float deltaY = initTouch.position.y - touch.position.y;
                rotZ -= (deltaX * Time.deltaTime * rotSpeed) - (deltaY * Time.deltaTime * rotSpeed);
                cam.transform.eulerAngles = new Vector3(0f, 0f, rotZ);
            }
            else if(touch.phase == TouchPhase.Ended)
            {
                initTouch = new Touch();
            }
        }
    }
}
