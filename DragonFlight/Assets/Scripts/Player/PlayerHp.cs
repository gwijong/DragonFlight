
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int hp = 1;

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
