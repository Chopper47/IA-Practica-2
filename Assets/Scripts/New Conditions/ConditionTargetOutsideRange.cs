using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Checks if the target is outside the character's detection range
/// </summary>
public class ConditionTargetOutsideRange : ICondition
{
    public CharacterStatus agent;
    public Transform target;


    public override bool Test()
    {

        if (target == null)
        {
            return false;
        }

        agent.newSearch = true;
        return (agent.transform.position - target.transform.position).magnitude >= agent.range;
    }
}
