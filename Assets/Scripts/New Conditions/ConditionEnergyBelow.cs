using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Checks if the character's energy is below the threshold
/// </summary>
public class ConditionEnergyBelow : ICondition
{
    public CharacterStatus characterToCheck;

    public int cost = 2;
    public override bool Test()
    {
        if (characterToCheck.energy < cost && !characterToCheck.isResting)
        {
            return true;

        }
        return false;
    }
}
