using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReleaseBall : MonoBehaviour
{
    public float speed = 2;
    public bool btnClick = false;
    public Transform ballPos;
    //public Transform parent;
    // Start is called before the first frame update
    void Start()
    {
        ballPos = GameObject.FindGameObjectWithTag("Location").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (btnClick == false)
        {
            transform.position = ballPos.transform.position;
            transform.rotation = ballPos.transform.rotation;
        }
 
        
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.parent = null;
            btnClick = true;
        }
        
        if(btnClick == true)
		{
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Wall")
		{
            Destroy(gameObject);
            Debug.Log("Destroy");
		}
        if(tag == "Yellow" && other.tag == "Yellow2")
		{
            Destroy(gameObject);
            Debug.Log("Yellow");
		}
        
        else if (tag == "Purple" && other.tag == "Purple2")
        {
            Destroy(gameObject);
            Debug.Log("Purple");
        }
        
        else if (tag == "Blue" && other.tag == "Blue2")
        {
            Destroy(gameObject);
            Debug.Log("Blue");
        }
        
       else if (tag == "Orange" && other.tag == "Orange2")
        {
            Destroy(gameObject);
            Debug.Log("Orange");
        }

        else if (tag == "Black" && other.tag == "Black2")
        {
            Destroy(gameObject);
            Debug.Log("Black");
        }

        else if (tag == "Pink" && other.tag == "Pink2")
        {
            Destroy(gameObject);
            Debug.Log("Pink");
        }
    }

}
