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

    private void Awake()
    {
        playerArea = GameObject.Find("PlayerArea");
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOverDropZone = true;
        dropZone = collision.gameObject;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isOverDropZone = false;
        dropZone = null;
    }

    public void StartDrag()
    {
        if (transform.parent == playerArea.transform)
        {
            startPosition = transform.position;
            isDragging = true;
        }
    }

    public abstract void EndDrag();
}
