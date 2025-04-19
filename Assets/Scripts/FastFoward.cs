using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastFoward : MonoBehaviour
{
    bool fastForward = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (fastForward)
            {
                fastForward = false;
                Time.timeScale = 1f;
            }
            else
            {
                fastForward = true;
                Time.timeScale = 4f;
            } 
        }
    }
}
