using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoLineMove : MonoBehaviour
{
    GameObject player;
    public float speed = 0.01f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        float x = (player.transform.position.x - this.transform.position.x);
        this.transform.Translate(x * speed * Time.deltaTime, 0, 0);
    }
}
