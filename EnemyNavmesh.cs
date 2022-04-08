using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavmesh : MonoBehaviour
{
    public DestinationPosition destinationPos;
    private NavMeshAgent navmeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        navmeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        navmeshAgent.destination = destinationPos.destinationPos;
    }
}
