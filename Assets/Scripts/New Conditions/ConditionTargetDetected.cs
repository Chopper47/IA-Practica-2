using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

/// <summary>
/// Checks if the target is within the character's detection range
/// </summary>
public class ConditionTargetDetected : ICondition
{
    public CharacterStatus agent;
    public Transform target;


    public override bool Test()
    {

        if (target == null)
        {
            return false;
        }

        return (agent.transform.position - target.transform.position).magnitude <= agent.range;
    }
}
