using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	public void StartGame()
    {
        // Change to the Game Scene
        Debug.Log("Start Game");
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }

    public void LoadGame()
    {
        Debug.Log("Load Game");
    }

    public void Options()
    {
        Debug.Log("Options Menu??");
    }

    public void ExitGame()
    {
        Debug.Log("Exit Game");
    }
}
