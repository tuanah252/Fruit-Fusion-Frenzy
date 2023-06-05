using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClick : MonoBehaviour
{
    private bool isMouseDown;
    private Vector3 lastMousePosition;

    void OnMouseDown()
    {
        isMouseDown = true;
        lastMousePosition = Input.mousePosition;
        Vector3 currentMousePosition = Input.mousePosition;
        float deltaX = currentMousePosition.x - lastMousePosition.x;
        float deltaY = currentMousePosition.y - lastMousePosition.y;
        float angle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg + 90f;
        transform.Rotate(new Vector3(0, 0, angle));
        lastMousePosition = currentMousePosition;
    }

    void OnMouseUp()
    {
        isMouseDown = false;
    }


}
