using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FindPlayer : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform target;
    [SerializeField] private float findTargetRate;
    [SerializeField] private float initialDelay;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        InvokeRepeating("FindTarget", initialDelay, findTargetRate);
    }

    private void FindTarget()
    {
        agent.destination = target.position;
    }
}
