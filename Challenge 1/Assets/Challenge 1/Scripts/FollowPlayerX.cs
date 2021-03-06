/*
 * Zach Daly
 * Assignment 2
 * Tells the camera to follow the player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// attach to camera
public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(30, 0, 10);
    
    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
