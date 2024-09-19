using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sayu : MonoBehaviour
{
    public int speed = 10;
    public float minX = -4f;  // X軸の最小値
    public float maxX = 4f;   // X軸の最大値
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
        // X軸の移動制限を追加
        Vector3 position = transform.position;
        position.x = Mathf.Clamp(position.x, minX, maxX);
        transform.position = position;
    }
  
}
