using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//SceneManagement will be used to move the players view from scene to scene.
//This will make it easier to move scenes when used in multiple scripts.

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; 
    // the game be default is set to not being in the pause state.

    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // if the "ESC" key is pressed this will happen.
        {
            if (GameIsPaused) // check to see if game is paused
            {
                Resume(); // if game is paused and "ESC" key pressed then resume the game.
            }
            else // otherwise do this...
            {
                Pause(); // if game is not paused and "ESC" key pressed then pause the game.
            }
        }
    }

    public void Resume () // this defines what resume game does in the code i used above.
    {
        pauseMenuUI.SetActive(false); // when game is resumed turn off the PauseMenu UI.
        Time.timeScale = 1f; // Game time is running normally.
        GameIsPaused = false; // declaring that the game is infact active and not paused
    }

    void Pause () // This defines the pause game does in the code i used in the update function
    {
        pauseMenuUI.SetActive(true); // When game is paused, the game Menu will pop up.
        Time.timeScale = 0f; // set time to 0 (stop time), so when the game is paused, time will not affect the game.
        GameIsPaused = true; // declaring that the game is infact in a paused state.
    }

    public void LoadMenu() // Function that takes player back to the Main Menu.
    {
        Time.timeScale = 1f; // Time gets returned back to normal speed.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // will open sceneManager and find the numerical value of current scene.
        //then this value will be reduced by 1. the game scene will change to the scene with the new numerical value.
    }

    public void QuitGame() // What happens when quit button is pressed during the pause menu.
    {
        Debug.Log("You Have Quit Polar Velocity. See you Next Time! :)"); // Shows message in console to tell the
                                                                          // player that the game has been quit.
        Application.Quit(); // the application / game has been quit.
    }

}
