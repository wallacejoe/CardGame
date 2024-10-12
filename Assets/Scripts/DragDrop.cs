using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DragDrop : MonoBehaviour
{
    protected bool isDragging = false;
    protected bool isOverDropZone = false;
    protected GameObject dropZone;
    protected Vector2 startPosition;
    protected GameObject playerArea;

    // An alternate method for storing objects in your class
    private void Awake()
    {
        playerArea = GameObject.Find("PlayerArea");
    }

    // Moves the card being "dragged" based on where your mouse
    // is positioned
    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    // Uses the Unity Collision2D class to detect when the card
    // enters a "playable" area
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    // Uses the Unity Collision2D class to detect when the card
    // leaves a "playable" area
    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    // If the card is being selected from the playerArea, begins
    // "dragging" the card
    public void StartDrag()
    {
        if (transform.parent == playerArea.transform)
        {
            startPosition = transform.position;
            isDragging = true;
        }
    }

    // Stops "dragging" the card once the card is released
    // Effects vary depending on card type
    public abstract void EndDrag();
}
