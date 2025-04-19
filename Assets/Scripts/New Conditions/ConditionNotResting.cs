using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks if the character has finished resting
/// </summary>
public class ConditionNotResting : ICondition
{
    public CharacterStatus characterToCheck;
    public override bool Test()
    {
        if (!characterToCheck.isResting)
        {
            return true;

        }
        return false;
    }
}
