using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C9 : DragDrop
{
    public override void EndDrag()
    {
        isDragging = false;
        if (transform.parent == playerArea.transform)
        {
            if (isOverDropZone)
            {
                if (dropZone.transform.childCount > 0)
                {
                    if (dropZone.transform.GetChild(0).gameObject.name == "Card8(Clone)" || dropZone.transform.GetChild(0).gameObject.name == "Card10(Clone)")
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
