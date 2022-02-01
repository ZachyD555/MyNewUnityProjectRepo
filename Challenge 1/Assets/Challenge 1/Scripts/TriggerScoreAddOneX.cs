/*
 * Zach Daly
 * Assignment 2
 * Controls when score is added
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Attach to triggerZones
public class TriggerScoreAddOneX : MonoBehaviour
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
