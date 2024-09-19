using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Butukaru : MonoBehaviour
{
    public GameObject sinka;
    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("ScoreText");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(this.gameObject.name == collision.gameObject.name)
        {
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Butukaru>().sinka = null;
            if(sinka)
            {
                Instantiate(sinka, this.transform.position, transform.rotation);
            }
            scoreText.GetComponent<ScoreManager>().score = scoreText.GetComponent<ScoreManager>().score + 100; ;
        }
    }
}
