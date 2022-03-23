using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public GameObject coin;
    public float coinRange = 0.5f;
    public float coinPower = 20;
    public void DropCoin(int coinCount)
    {
        if (coinCount >= 1)
        {
            for (int i = 0; i < coinCount; i++)
            {
                GameObject co = Instantiate(coin);
                co.transform.position = transform.position + new Vector3(Random.Range(-coinRange, coinRange), Random.Range(-coinRange, coinRange),0);
                co.GetComponent<Rigidbody2D>().AddForce(Vector3.right * Random.Range(-coinPower, coinPower*2));
                co.GetComponent<Rigidbody2D>().AddForce(Vector3.left * Random.Range(-coinPower, coinPower*2));
                co.GetComponent<Rigidbody2D>().AddForce(Vector3.up * Random.Range(-coinPower, coinPower*2));
            }
        }
    }
}
