using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;    // A variable that stores a reference to the Player
    public Vector3 offset;      // A variable that allows us to offset the position of the camera by - (x, y, z)

    // Update is called once per frame
    void Update()
    {
        // Set the position to the players position and offset it by however much needed
        transform.position = player.position + offset;
    }
}
