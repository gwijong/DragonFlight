using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    public int hp = 1;
    public GameObject coin;
    public GameObject destroyParticle;
    private void Update()
    {

    }

    public void Hit(int AttackDamage)
    {
        hp = hp - AttackDamage;
        if (hp <= 0)
        {
            int random = Random.Range(0, 4);
            GameManager.instance.AddScore(500);
            if(random == 0)
            {
                Coin1();
            }
            else if(random == 1)
            {
                Coin2();
                Coin1();
            }
            else if(random == 2)
            {
                Coin3();
                Coin1();
            }
            else
            {
                Coin1();
                Coin2();
                Coin3();
            }
            GameObject dest = Instantiate(destroyParticle);
            dest.transform.position = transform.position;
            gameObject.SetActive(false);
        }
    }
    void Coin1()
    {
        GameObject co1 = Instantiate(coin);
        co1.transform.position = transform.position;
        co1.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 20);
    }
    void Coin2()
    {
        GameObject co2 = Instantiate(coin);
        co2.transform.position = transform.position + new Vector3(-0.2f, 0.2f, 0); ;
        co2.GetComponent<Rigidbody2D>().AddForce(Vector3.left * 20);
    }
    void Coin3()
    {
        GameObject co3 = Instantiate(coin);
        co3.transform.position = transform.position + new Vector3(0.2f, 0.2f, 0);
        co3.GetComponent<Rigidbody2D>().AddForce(Vector3.right * 20);
    }
}
