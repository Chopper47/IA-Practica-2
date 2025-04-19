using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Checks if the character's energy is above the threshold
/// </summary>
public class ConditionEnergyOver : ICondition
{
    public CharacterStatus characterToCheck;

    public int cost = 2;
    public override bool Test()
    {
        if (characterToCheck.energy >= cost) 
        {
            return true;

        }
        return false;
    }
}
