using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stops for 5 seconds, while it's detection range increases
/// </summary>
public class ActionWatch : IAction
{
    public CharacterStatus characterToAct;
    public override void Act()
    {
        if(!characterToAct.isWatching)
        {

            StartCoroutine(characterToAct.Watch());

        }
    }
}
