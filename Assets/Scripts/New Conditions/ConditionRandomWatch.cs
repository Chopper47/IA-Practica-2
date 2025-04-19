using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks if the character should start the watch action
/// </summary>
public class ConditionRandomWatch : ICondition
{
    public CharacterStatus characterToCheck;
    public override bool Test()
    {
        if (characterToCheck.shouldWatch)
        {
            characterToCheck.shouldWatch = false;
            return true;
        }
        return false;
    }
}
