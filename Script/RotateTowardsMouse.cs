using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTowardsMouse : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 direction;
    Quaternion updateRotation;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - transform.position;

        updateRotation = Quaternion.LookRotation(Vector3.up, direction);
        transform.rotation = updateRotation;
        

    }

}
