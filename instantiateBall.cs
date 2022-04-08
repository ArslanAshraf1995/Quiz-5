using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateBall : MonoBehaviour
{
    public GameObject[] diffBalls;
    public int ballNo;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(diffBalls[Random.Range(0, diffBalls.Length)], transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Mouse0))
		{
            ballNo = Random.Range(0, diffBalls.Length);
            Instantiate(diffBalls[ballNo], transform.position, transform.rotation);
        }
       

    }
}
