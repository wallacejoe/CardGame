using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject Card3;
    public GameObject Card4;
    public GameObject Card5;
    public GameObject Card6;
    public GameObject Card7;
    public GameObject Card8;
    public GameObject Card9;
    public GameObject Card10;
    public GameObject playerArea;

    List<GameObject> cards = new List<GameObject>();

    // This method is run initially on creation of the object
    // It adds each card type to the Canvas object
    // It then adds five cards to the playerArea
    private void Start()
    {
        cards.Add(Card1);
        cards.Add(Card2);
        cards.Add(Card3);
        cards.Add(Card4);
        cards.Add(Card5);
        cards.Add(Card6);
        cards.Add(Card7);
        cards.Add(Card8);
        cards.Add(Card9);
        cards.Add(Card10);

        for (int i = 0; i < 5; i++)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);
        }
    }

    // Checks the playerArea late every frame, adding cards if the
    // playerArea contains less than five
    private void LateUpdate()
    {
        if (playerArea.transform.childCount < 5)
        {
            GameObject playerCard = Instantiate(cards[Random.Range(0, cards.Count)], new Vector3(0, 0, 0), Quaternion.identity);
            playerCard.transform.SetParent(playerArea.transform, false);
        }
    }
}
