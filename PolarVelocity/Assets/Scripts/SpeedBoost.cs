using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoost : MonoBehaviour
{
    public float multiplier = 1.5f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PenguinModel")
        {
            PlayerController.movementSpeed *= multiplier;
            Destroy(gameObject); //Self Destruct

        }
    }
}
