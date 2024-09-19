using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampSide : MonoBehaviour
{
    private float minX = -3.5f;
    private float maxX = 3.5f;
    void Start()
    {
        //LimitMinMaxX();
    }
    void Update()
    {
        if (transform.position.x < minX)
        {
            Vector3 temp = transform.position;
            temp.x = minX;
            transform.position = temp;
        }
        if (transform.position.x > maxX)
        {
            Vector3 temp = transform.position;
            temp.x = maxX;
            transform.position = temp;
        }
    }
}
