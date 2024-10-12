using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C6 : DragDrop
{
    // Stops "dragging" the card once the card is released
    // If the card originated from the playerArea, it checks to
    // ensure it's in a playable area (dropZone), then checks
    // it the current card in the dropZone is a correct value
    public override void EndDrag()
    {
        isDragging = false;
        if (transform.parent == playerArea.transform)
        {
            if (isOverDropZone)
            {
                if (dropZone.transform.childCount > 0)
                {
                    if (dropZone.transform.GetChild(0).gameObject.name == "Card5(Clone)" || dropZone.transform.GetChild(0).gameObject.name == "Card7(Clone)")
                    {
                        Destroy(dropZone.transform.GetChild(0).gameObject);
                        transform.SetParent(dropZone.transform, false);
                    }
                    else
                    {
                        transform.position = startPosition;
                    }
                }
                else
                {
                    transform.SetParent(dropZone.transform, false);
                }
            }
            else
            {
                transform.position = startPosition;
            }
        }
    }
}
