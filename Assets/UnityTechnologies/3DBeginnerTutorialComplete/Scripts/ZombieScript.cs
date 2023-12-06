using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class ZombieScript : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    Animator m_Animator;

    int m_CurrentWaypointIndex;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        InvokeRepeating("updatenode", 1f, 2f);
        

    }
    void updatenode ()
        {
        navMeshAgent.SetDestination(waypoints[0].position);
        
       
    }

    void Update()
    {
        if (navMeshAgent.remainingDistance < navMeshAgent.stoppingDistance)
        {
            m_CurrentWaypointIndex = (m_CurrentWaypointIndex + 1) % waypoints.Length;
            navMeshAgent.SetDestination(waypoints[m_CurrentWaypointIndex].position);
            
            
        }

    }
     
}
