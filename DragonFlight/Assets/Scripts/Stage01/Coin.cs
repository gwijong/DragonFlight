using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject player;
    float time;
    float distance;
    public float magnetRange = 3.0f;
    public float magnetPower = 30.0f;
    void Start()
    {
        time = 0;
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        DestroyTimer();
        Magnet();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.AddScore(1000);
            Destroy(gameObject);
        }

        if (collision.gameObject.tag == "Destroy")
        {
            Destroy(gameObject);
        }
    }

    void Magnet()
    {
        if ((transform.position - player.transform.position).magnitude < magnetRange)
        {
            transform.Translate((player.transform.position - transform.position).normalized * Time.deltaTime * magnetPower);
        }
    }

    void DestroyTimer()
    {
        time = time + Time.deltaTime;
        if (time > 5)
        {
            Destroy(gameObject);
        }
    }
}
