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

    // Checks the playerArea every frame, reducing the remainingDeck
    // count if there are less than 5 cards. If remainingDeck is less
    // than one, the gameOver method is called
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

    // Changes the scene to the GameWin scene
    private void GameOver()
    {
        SceneManager.LoadSceneAsync("GameWin");
    }
}
