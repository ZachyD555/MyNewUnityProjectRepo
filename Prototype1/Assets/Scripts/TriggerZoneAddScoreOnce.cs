/*
* Zach Daly
* Assignment 2
* Controls Score and trigger zones
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Attach to a Trigger Zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }
    }
}