using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    using System.Collections.Generic;
using UnityEngine;
public class DragAndDrop : MonoBehaviour
{
    private Vector3 offset;
    void OnMouseDown()
    {
        offset = gameObject.transform.position -
            Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
    }
    void OnMouseDrag()
    {
        Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y);
        transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
    }
    private void OnMouseUp()
    {
        Debug.Log("Drag and Drop is over");
    }
}

