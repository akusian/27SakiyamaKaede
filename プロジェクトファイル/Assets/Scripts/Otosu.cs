using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Otosu : MonoBehaviour
{
    public GameObject[] kudamono;

    public static UnityEvent OnGameOver = new UnityEvent();
    private bool isInside = false;
    // Start is called before the first frame update
    void Start()
    {
        if (!isInside)
        {
            OnGameOver.Invoke();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        isInside = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(kudamono[GameObject.Find("ネクスト").GetComponent<Next>().bango],this.transform.position,this.transform.rotation);

            GameObject.Find("ネクスト").GetComponent<Next>().Change();

        }
        OnGameOver.Invoke();

    }
   
}
