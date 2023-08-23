using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float turnSpeed = 30;
    Rigidbody player_rb;

    // Start is called before the first frame update
    void Start()
    {
        player_rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //get movement values from keyboard
        horizontalInput = 2*(Input.GetAxis("Horizontal"));
        verticalInput = 2*(Input.GetAxis("Vertical"));

        // move the object
        player_rb.MovePosition(Vector3.forward * Time.deltaTime * verticalInput);
        player_rb.MovePosition(Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up * horizontalInput * turnSpeed * Time.deltaTime);

    }
}
