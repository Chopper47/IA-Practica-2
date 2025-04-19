using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ActionChase : IAction
{

    public Transform target;
    public NavMeshAgent agent;

    public override void Act()
    {
        agent.SetDestination(target.position);
    }
}
