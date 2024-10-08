using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Deck : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI deckText;
    [SerializeField] float remainingDeck;
    public GameObject playerArea;

    /*private void Start()
    {
        remainingDeck = 30;
    }*/

    private void Update()
    {
        if (playerArea.transform.childCount < 5)
        {
            remainingDeck -= 1;
            deckText.text = remainingDeck.ToString();
        }

        if (remainingDeck <= 0)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        SceneManager.LoadSceneAsync("GameWin");
    }
}
