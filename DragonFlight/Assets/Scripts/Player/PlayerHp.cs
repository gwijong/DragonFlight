using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerHp : MonoBehaviour
{
    public int hp = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy" || collision.tag == "Meteo" || collision.tag == "EnemyBullet")
        {
            hp -= 1;
        }
        if (hp <= 0)
        {
            GameManager.instance.OnPlayerDead();          
            gameObject.SetActive(false);
        }
    }
}
