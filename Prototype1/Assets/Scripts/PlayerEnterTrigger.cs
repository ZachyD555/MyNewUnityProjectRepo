using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

// Attach this to player
public class PlayerEnterTrigger : MonoBehaviour
{
    // set this ref in inspector
    //public Text textbox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
            //textbox.text = "You Win!!";
            ScoreManager.score++;
    }
}
