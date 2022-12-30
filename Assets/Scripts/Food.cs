using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private Vector3 pos;
    public float offset = 3f;
    private bool followCursor = true;

    private void Update()
    {
        if (followCursor)
        {
            pos = Input.mousePosition;
            pos.z = offset;
            transform.position = Camera.main.ScreenToWorldPoint(pos);
        }

        if (Input.GetMouseButtonDown(0))
        {
            followCursor = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Food : OnCollisionEnter()");
    }
}
