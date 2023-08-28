using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    private float startTime; // starting time at start of lap.
    private float elapsedTime; // how much time has been passed.
    private bool hasStartedLap = false; // default setting of players lap.
    // since the player has not started a lap at start of game. the default setting is set to false.

    public GameObject lapText; // text for current lap

    public GameObject prevLapText; // text for previous lap

    public GameObject bestLap; // text for best lap

    List<float> bestTimes = new List<float>(); // make a list of all lap times.
                                               // this will be used to calculate the best lap time and display it.

    // Update is called once per frame
    void Update()
    {
        if (hasStartedLap) // if the lap has been started.
        {

            elapsedTime = Time.time - startTime; // once a lap has begun subtract
                                                 // the time at start of lap from the current time.
            //Debug.Log(elapsedTime);

            lapText.GetComponent<Text>().text = "Lap Time: " + elapsedTime.ToString();
            // Gets the current lap time text and turns the lap timer to a string to display.
        }
    }

    private void OnTriggerEnter(Collider other) // when the finish line detects a collider passing through it.
    {
        if (other.CompareTag("Player")) // it compares its tag to check if it is the player crossing.
        {

            hasStartedLap = true; // if it is the player than the lap has been started
            startTime = Time.time; // therfore the timer starts running

            prevLapText.GetComponent<Text>().text = "Last Lap: " + elapsedTime.ToString();
            // this will then take the time taken to complete the previous lap and display the old lap time.
        }

        if (elapsedTime != 0)
        {

            bestTimes.Add(elapsedTime);

        }

        if (bestTimes.Count > 0) // if there has been more that 0 laps completed, 
        {

            bestTimes.Sort(); // the list is sorted and the lowest value lap time is selected.
            bestLap.GetComponent<Text>().text = "Best Lap: " + bestTimes[0].ToString();
            // the lowest lap time is then displayed on the screen until the list updates and finds a new faster lap time.
        }
    }
}
