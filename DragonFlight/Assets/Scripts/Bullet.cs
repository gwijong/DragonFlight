using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int bulletDamage = 1;
    void OnParticleCollision(GameObject other)
    {
        if(other != null && other.activeSelf == true)
        other.GetComponent<EnemyHp>().Hit(bulletDamage);
    }
}
