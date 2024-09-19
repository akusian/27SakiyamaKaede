using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLimit : MonoBehaviour
{
    private float minX;
    private float maxX;
    void Start()
    {
        LimitMinMaxX();
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
    void LimitMinMaxX()
    {
        Vector3 limit = Camera.main.ScreenToWorldPoint
        (new Vector3(Screen.width, Screen.height, 0));
        maxX = limit.x;
        minX = -limit.x;
    }
}
