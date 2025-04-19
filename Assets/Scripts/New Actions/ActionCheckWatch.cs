using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Checks if it should start the watch method, then waits 10 seconds
/// </summary>
public class ActionCheckWatch : IAction
{
    public CharacterStatus characterToAct;
    public override void Act()
    {
        if (!characterToAct.checkingToWatch)
        {

            StartCoroutine(characterToAct.RandomWatch());
        }
    }
}
