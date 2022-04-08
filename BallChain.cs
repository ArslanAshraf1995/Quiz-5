using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallChain : MonoBehaviour
{
    public GameObject[] ballChain;
    public int randomNum;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0.5f, 0.40f);
    }

    // Update is called once per frame
    public void spawn()
	{
        randomNum = Random.Range(0, ballChain.Length);
        Instantiate(ballChain[randomNum], transform.position, transform.rotation);
	}
}
