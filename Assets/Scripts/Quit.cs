using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quit : MonoBehaviour
{
    // Closes the application when activated
    public void OnClick()
    {
        Application.Quit();
    }
}
