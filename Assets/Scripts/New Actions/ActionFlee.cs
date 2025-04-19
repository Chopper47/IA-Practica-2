using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// Prey moves aaway from hunter
/// </summary>
public class ActionFlee : IAction
{
    public NavMeshAgent agent;
    public Transform target;
    public override void Act()
    {
        Vector3 dirToTarget = agent.transform.position - target.transform.position;

        Vector3 newPos = agent.transform.position + dirToTarget;

        agent.SetDestination(newPos);
    }
}
