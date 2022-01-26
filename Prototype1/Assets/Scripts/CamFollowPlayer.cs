/*
* Zach Daly
* Assignment 2
* Following code makes the camera follow 
* player vehicle.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollowPlayer : MonoBehaviour
{
    // Drag the player onto this reference in the Inspector
    public GameObject player;

    private Vector3 offset = new Vector3(0, 7, -15);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
