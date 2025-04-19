using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks if the character has finished doing the watch action
/// </summary>
public class ConditionNotWatching : ICondition
{
    public CharacterStatus characterToCheck;
    public override bool Test()
    {
        if (!characterToCheck.isWatching)
        {
            return true;

        }
        return false;
    }
}
