using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stops the watch corroutine of the character
/// </summary>
public class ActionStopWatching : IAction
{
    public CharacterStatus characterToAct;
    public override void Act()
    {
        StopCoroutine(characterToAct.Watch());
        characterToAct.range -= 5;
        characterToAct.isWatching = false;
        characterToAct.watchMarker.SetActive(false);
    }
}
