using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using PauseMenuInputScript;

public class PauseMenu : MonoBehaviour

{

    public AudioSource audio;
    //
    private PauseMenuInputAction playerControls;

    //
    private InputAction gamePauseMenu;
    
    //
    [SerializeField] GameObject pauseMenu;

    //
    int scene;

    //
    public GameObject optionsMenu;

    //
    public static bool isPaused = false;

    //
    void Awake() 
    
    {

        playerControls = new PauseMenuInputAction();


    }

    //
    void OnEnable()

    {

        gamePauseMenu = playerControls.PauseMenu.GamePauseMenu;
        gamePauseMenu.Enable();

        gamePauseMenu.performed += PauseButtonPressed;


    }

    //
    void OnDisable() 

    {   

        gamePauseMenu.Disable();


    }

    //
    void PauseButtonPressed(InputAction.CallbackContext context)

    {
        if (context.performed) 

        {
            if (isPaused) 

            {
                ResumeGame();
            }
            
            else

            {
                PauseGame();
            }
            
        }

    }

    //
    public void ReturnToTimeline() 

    {
        SceneManager.LoadSceneAsync(1);
    }

    //
    public void ResumeGame() 

    {
        audio.Play();
        pauseMenu.SetActive(false);
        scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadSceneAsync(scene);
        Time.timeScale = 1.0f;
        isPaused = false;
    }

    //
    public void QuitGame() 
    
    {
        Application.Quit();
    }
    
    //
    public void PauseGame() 

    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0.0f;
        isPaused = true;
    }

    //
    public void Options()

    {
        optionsMenu.SetActive(true);
        pauseMenu.SetActive(false);
    }

}

