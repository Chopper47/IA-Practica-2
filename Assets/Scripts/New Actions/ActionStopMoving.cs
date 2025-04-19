using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// Called when resting and watching. Makes the character stop moving
/// </summary>
public class ActionStopMoving : IAction
{
    public NavMeshAgent agent;
    public override void Act()
    {
        agent.gameObject.GetComponent<CharacterStatus>().newSearch = true;
        agent.SetDestination(agent.transform.position);
    }
}
