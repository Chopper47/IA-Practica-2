using UnityEngine;
using System.Collections;

/// <summary>
/// Destroys an object
/// </summary>
public class ActionDestroyObject : IAction
{
	public GameObject objectToDestroy;
	public GameObject stateMachine;

	public override void Act ()
	{
		if (objectToDestroy == null)	return;

		stateMachine.SetActive(false);
		Destroy(objectToDestroy);
	}
}
