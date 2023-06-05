using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDrag : MonoBehaviour
{


    // Start is called before the first frame update
    private bool check;
    Vector3 offset;
    private object collision;
    public float rotationSpeed = 10f;
    private void Update()
    {
        // Xoay đối tượng xung quanh trục Z
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
    void OnMouseDown()
    {
        check = true;
    }
    void OnMouseDrag()
    {
        if (check)
        {

            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


        }

    }
    void OnCollisionEnter(Collision other)
    {
        check = false;
    }
}


