using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject player;
    float time;
    float distance;
    void Start()
    {
        time = 0;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;
        if (time > 5)
        {
            gameObject.SetActive(false);
        }

        if((transform.position - player.transform.position).magnitude < 2f)
        {
            transform.Translate((player.transform.position-transform.position).normalized * Time.deltaTime * 10.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.AddScore(1000);
            gameObject.SetActive(false);
        }
    }
}
