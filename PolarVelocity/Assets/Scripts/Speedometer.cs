using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    public Rigidbody thePenguin; // holds the rigidbody of the player object,
                                 // which allows us to calculate speed

    public float maxSpeed = 0.0f;
    public float minSpeedPointerAngle; // when speed of penguin is 0,
    // where do we want the angle of the pointer to be set at.
    public float maxSpeedPointerAngle;
    //When speed of penguin is at its maximum, where does the pointer end at.
    public RectTransform pointerHolder; // tranforming the angle of the pointer
    public TMPro.TMP_Text speedLabel; // change the digital speed display
    public float speed; // speed of pointer chnaging rate.
    private Vector3 oldPosition; // old position needed to calculate the speed.

    void Update ()
    {
        speed = thePenguin.velocity.magnitude * 3.6f; // penguin rigidbodys velocity
                                                      // multiplied by 3.6. 3.6 converts it into kilometers per hour.
        Debug.Log("Speed of penguin is: " + speed); // makes sure that the speed is being output.
        //can be removed if not wanted.
        speedLabel.text = (int)speed + ""; //speed.ToString();
        // makes it into an integer so that the km/h text doesnt have unnessessary decimal points.
        // e.g. 34.985864436 km/h to just 35 km/h
        speedLabel.alignment = TMPro.TextAlignmentOptions.Center; // aligns the text to the centre of the speedometer.

        pointerHolder.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeedPointerAngle, maxSpeedPointerAngle, speed / maxSpeed));
        // Changes the angle of the pointer depending on the velocity of the penguin.
    }

}
