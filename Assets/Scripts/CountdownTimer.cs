using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI countdownText;
    [SerializeField] float remainingTime;

    /*private void Start()
    {
        remainingTime = 90;
    }*/

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

    private void GameOver()
    {
        SceneManager.LoadSceneAsync("GameOver");
    }

    public void ReduceTime()
    {
        remainingTime -= 5;
    }
}
