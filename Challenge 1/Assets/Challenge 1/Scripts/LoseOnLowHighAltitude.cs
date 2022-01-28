using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseOnLowHighAltitude : MonoBehaviour
{
    // set ref in inspector

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -51 || transform.position.y > 80)
            ScoreManager.gameOver = true;
    }
}
