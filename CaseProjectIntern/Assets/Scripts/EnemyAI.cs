using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{   
    public Transform target; // Player bile�enini atayaca��z

    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        agent.SetDestination(target.position); // Hedef pozisyonunu belirlemek i�in NavMeshAgent'e hedef pozisyonu atamas� yap�l�r.

    }
}
