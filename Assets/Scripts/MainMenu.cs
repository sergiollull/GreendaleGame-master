using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    /*public GameObject mainMenu;
    public GameObject game;*/
    public GameObject selectedCharacter;
    void Awake()
    {
        DontDestroyOnLoad(this);

    }
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // Starts the game
    }
    public void QuitGame()
    {
        //Debug.Log("Quit");
        Application.Quit(); // Quits the game
    }
    
    
}

