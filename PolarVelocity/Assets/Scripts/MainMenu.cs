using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//SceneManagement will be used to move the players view from scene to scene.
//This will make it easier to move scenes when used in multiple scripts.

public class MainMenu : MonoBehaviour
{
    public void PlayGame() //Function to start the game
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //SceneManager calls upon the "UnityEngine.SceneManagement" I added earlier
        // Goes into the scene manager and gets the number of the scene player is on
        // currently. It then adds 1 to the scene number and hops the camera over to
        // the scene with the corresponding number.
    }

    public void QuitGame() // function to quit game when qhuit button is pressed.
    {
        Debug.Log("YOU HAVE QUIT THE GAME!"); 
        // shows player that the game has been exited.
        Application.Quit();
        //The application, i.e. the game is quit.
    }
}
