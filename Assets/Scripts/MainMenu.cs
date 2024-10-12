using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Takes the user to the GamePlay scene, the "easy" game mode
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("GamePlay");
    }

    // Takes the user to the GamePlay scene, the "medium" game mode
    public void PlayMedium()
    {
        SceneManager.LoadSceneAsync("GamePlayMedium");
    }

    // Takes the user to the GamePlayHard scene, the "hard" game mode
    public void PlayHard()
    {
        SceneManager.LoadSceneAsync("GamePlayHard");
    }
}
