using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] float remainingTime;

    // Sets the countdownTime format, and reduces the time
    // Calls the GameOver method if the time is lower than one
    private void Update()
    {
        remainingTime -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (remainingTime <= 0)
        {
            GameOver();
        }
    }

    // Changes the scene to the GameOver scene
    private void GameOver()
    {
        SceneManager.LoadSceneAsync("GameOver");
    }

    // Reduces the remaining time by five seconds
    public void ReduceTime()
    {
        remainingTime -= 5;
    }
}
