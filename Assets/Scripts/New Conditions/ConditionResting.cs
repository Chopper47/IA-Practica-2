using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks if the character is resting
/// </summary>
public class ConditionResting : ICondition
{
    public CharacterStatus characterToCheck;
    public override bool Test()
    {
        if (characterToCheck.isResting)
        {
            return true;

        }
        return false;
    }

}
