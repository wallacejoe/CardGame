using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    // Returns the user to the MainMenu scene when activated
    public void OnClick()
    {
        SceneManager.LoadSceneAsync("MainMenu");
    }
}
