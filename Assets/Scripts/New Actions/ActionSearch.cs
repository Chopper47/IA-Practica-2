using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class ActionSearch : IAction
{
    public Vector3 target = Vector3.zero;
    public NavMeshAgent agent;
    
    /// <summary>
    /// Choses a random target position to move to, if it can't get there it recalculates. 
    /// Only activates if it has reached it's previous destination or if the destination is 0.
    /// Also when a new search is needed manually, such as when it was chasing or fleeing from a target and it leaves it's range.
    /// ** No pude encontrar una forma de pasarle lo de nueva busqueda al cazador, que utiliza el arbol de decisiones, así que hay un bug que cuando la presa deja su rango, se queda parado en el sitio.
    /// </summary>
    public override void Act()
    {
        if (agent.transform.position == target || target == Vector3.zero || agent.gameObject.GetComponent<CharacterStatus>().newSearch)
        {
            agent.gameObject.GetComponent<CharacterStatus>().newSearch = false;
            target = new Vector3(agent.transform.position.x + Random.Range(-10f, 10f), agent.transform.position.y, agent.transform.position.z + Random.Range(-10f, 10f));

            var navMeshPath = new NavMeshPath();
            while(!agent.CalculatePath(target, navMeshPath))
            {
                target = new Vector3(agent.transform.position.x + Random.Range(-10f, 10f), agent.transform.position.y, agent.transform.position.z + Random.Range(-10f, 10f));
            }

            
            agent.SetDestination(target);
            agent.gameObject.GetComponent<CharacterStatus>().ReduceEnergy();
            
        }


        return;
    }
}
