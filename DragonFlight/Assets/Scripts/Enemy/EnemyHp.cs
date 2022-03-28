using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHp : MonoBehaviour
{
    bool isdead = false;
    public int hp = 1;
    public int maxhp = 1;
    public GameObject destroyParticle;

    private void OnEnable()
    {
        isdead = false;
        hp = maxhp;
    }
    public void Hit(int AttackDamage)
    {
        hp = hp - AttackDamage;
        if (hp <= 0 && isdead == false)
        {
            isdead = true;
            GameManager.instance.AddScore(500);
            GameObject dest = Instantiate(destroyParticle);
            dest.transform.position = transform.position;        
            gameObject.GetComponent<DropItem>().DropCoin(Random.Range(0,6));
            StartCoroutine("DeadTimer");
        }
    }

    IEnumerator DeadTimer()
    {
        yield return new WaitForSeconds(0.05f);
        gameObject.SetActive(false);
    }

}
