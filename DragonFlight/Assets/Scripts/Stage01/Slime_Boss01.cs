using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Boss01 : MonoBehaviour
{
    public GameObject Child;
    bool flag1 = false;
    GameObject child1;
    GameObject child2;
    public float Speed = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.GetComponent<EnemyHp>().hp <= 10 && flag1 == false)
        {
            Debug.Log("슬라임 분열");
            flag1 = true;
            child1 = Instantiate(Child);
            child1.transform.position = transform.position + new Vector3(0.5f, 0, 0);
            child2 = Instantiate(Child);
            child2.transform.position = transform.position + new Vector3(-0.5f, 0, 0);
        }

        if(child1!=null && child2 != null)
        {
            child1.transform.Translate(1* Speed*Time.deltaTime, 0, 0);
            child2.transform.Translate(-1 * Speed * Time.deltaTime, 0, 0);
        }
    }
}
