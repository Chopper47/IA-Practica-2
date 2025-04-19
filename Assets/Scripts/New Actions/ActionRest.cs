using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Stops moving, waits for some seconds, then recovers energy. Also activates particles to show the action.
/// </summary>
public class ActionRest : IAction
{
    public CharacterStatus characterToAct;
    public override void Act()
    {
        if (!characterToAct.isResting)
        {
            StartCoroutine(characterToAct.Rest());

        }
    }
}
