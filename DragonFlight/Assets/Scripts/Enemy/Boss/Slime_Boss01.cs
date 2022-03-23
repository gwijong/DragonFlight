using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Boss01 : MonoBehaviour
{
    bool flag1 = false;
    public GameObject child1;
    public GameObject child2;
    float moveTime;

    void Update()
    {
        if (gameObject.GetComponent<EnemyHp>().hp <= 0 && flag1 == false)
        {
            flag1 = true;
            child1.SetActive(true);
            child2.SetActive(true);
            child1.transform.position = transform.position + new Vector3(Random.Range(0.8f, 1.2f), Random.Range(-0.4f, 0.4f), 0);
            child2.transform.position = transform.position + new Vector3(Random.Range(-1.2f, -0.8f), Random.Range(-0.4f, 0.4f), 0);
        }
    }
}
