using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedometer : MonoBehaviour
{
    public Rigidbody thePenguin;

    public float maxSpeed = 0.0f;
    public float minSpeedPointerAngle;
    public float maxSpeedPointerAngle;
    public RectTransform pointerHolder;
    public TMPro.TMP_Text speedLabel;
    public float speed;
    private Vector3 oldPosition;

    void Update ()
    {
        Debug.Log("test");
        Debug.Log(oldPosition);
        Debug.Log(transform.position);
        speed = Vector3.Distance(oldPosition, transform.position) * 100f;
        oldPosition = transform.position;

        Debug.Log("Speed: " + speed.ToString("F2"));


        //speed = thePenguin.velocity.magnitude * 3.6f;
        //Debug.Log("Speed of penguin is: " + speed);
        //speedLabel.text = (int)speed + ""; //speed.ToString();
        //speedLabel.alignment = TMPro.TextAlignmentOptions.Center;

        pointerHolder.localEulerAngles = new Vector3(0, 0, Mathf.Lerp(minSpeedPointerAngle, maxSpeedPointerAngle, speed / maxSpeed));
    }

}
