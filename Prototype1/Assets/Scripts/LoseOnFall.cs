using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

// attach to player
public class LoseOnFall : MonoBehaviour
{
   // Set ref in inspector
   // public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
            //textbox.text = "You Lose!!";
            ScoreManager.gameOver = true;
    }
}
