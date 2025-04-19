using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterStatus : MonoBehaviour
{
    public int maxEnergy;
    public int energy;

    public bool isResting;

    public GameObject particles;
    public GameObject watchMarker;

    public float range;

    public bool newSearch = false;

    public bool checkingToWatch;
    public bool shouldWatch;
    public bool isWatching;
    private void Awake()
    {
        energy = maxEnergy;
    }

   
    public void ReduceEnergy()
    {
        energy -= 2;
    }

    
    public IEnumerator Rest()
    {
        particles.SetActive(true);
        isResting = true;
        yield return new WaitForSeconds(10f);
        particles.SetActive(false);
        energy = maxEnergy;
        isResting = false;
    }

    public IEnumerator RandomWatch()
    {
        //Debug.Log("CHARACTER RANDOM WATCH");
        checkingToWatch = true;

        int rnd = Random.Range(0, 4);
        //Debug.Log("RANDOM NUMBER = " + rnd);
        if (rnd == 0) shouldWatch = true;
        else shouldWatch = false;

        yield return new WaitForSeconds(10);


        checkingToWatch = false;
    }
    public IEnumerator Watch()
    {
        //Debug.Log("WATCHING");
        isWatching = true;
        range += 5;
        watchMarker.SetActive(true);
        yield return new WaitForSeconds(5f);
        range -= 5;
        isWatching = false;
        watchMarker.SetActive(false);

    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
