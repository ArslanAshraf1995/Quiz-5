using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestinationPosition : MonoBehaviour
{
    public Vector3 destinationPos;
    public float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        destinationPos = transform.position;
    }

    // Update is called once per frame
    /*void Update()
    {
        if(transform.position.z == -2.39 && transform.position.x > -6.4)
		{
            transform.Translate(Vector3.right * speed * Time.deltaTime);
		}
        if (transform.position.z == -2.39 && transform.position.x == 6.7)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        if (transform.position.z == -8.80 && transform.position.x == 6.7)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (transform.position.z == -2.39 && transform.position.x > -6.5)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
    */
}
