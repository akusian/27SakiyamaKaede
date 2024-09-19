using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayu : MonoBehaviour
{
    public int speed = 10;
    public float minX = -4f;  // Xé≤ÇÃç≈è¨íl
    public float maxX = 4f;   // Xé≤ÇÃç≈ëÂíl
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed * 1 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(speed * -1 * Time.deltaTime, 0, 0);
        }
        // Xé≤ÇÃà⁄ìÆêßå¿Çí«â¡
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }
  
}
