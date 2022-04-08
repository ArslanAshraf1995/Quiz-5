using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
	private void OnTriggerEnter(Collider other)
	{
        if(other.tag == "Wall")
		{
            Destroy(gameObject);
		}

        if (tag == "Yellow2" && other.tag == "Yellow")
        {
            Destroy(gameObject);
        }

        else if (tag == "Purple2" && other.tag == "Purple")
        {
            Destroy(gameObject);
        }

        else if (tag == "Blue2" && other.tag == "Blue")
        {
            Destroy(gameObject);
        }

        else if (tag == "Orange2" && other.tag == "Orange")
        {
            Destroy(gameObject);
        }

        else if (tag == "Black2" && other.tag == "Black")
        {
            Destroy(gameObject);
        }

        else if (tag == "Pink2" && other.tag == "Pink")
        {
            Destroy(gameObject);
        }
    }
}
