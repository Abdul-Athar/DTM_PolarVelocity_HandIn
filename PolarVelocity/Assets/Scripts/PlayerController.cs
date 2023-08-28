using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    CharacterController ch; // rather than hard coding the characterController
    // I can call upon this so that it is easier and faster to code.

    // Start is called before the first frame update
    void Start()
    {
        ch = GetComponent<CharacterController>(); // Find the characterController
        //used on the penguin model.
    }


    // Update is called once per frame
    void FixedUpdate() // called every specific time rather than every inconsistant frame.
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        // Gets the horiziontal inputs, i.e. A, D and the left and right arrow keys.
        // multiplied by the movement speed that can be changed in the editor and
        // multiplied by time (seconds)
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        // Gets the vertical input , i.e. W, S and the up, down arrow keys.
        // multiplied by the movement speed that can be changed in the editor and
        // multiplied by time (seconds)
        ch.Move(new Vector3(x, 0, z)); // locates the new coordinates
        // of the penguins character controller.
    }
}
