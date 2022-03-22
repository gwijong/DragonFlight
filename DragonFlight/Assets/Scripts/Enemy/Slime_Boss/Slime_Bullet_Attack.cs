using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Bullet_Attack : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 1;
    public int oneShoting = 6;
    void Start()
    {
        StartCoroutine("SpellStart");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpellStart()
    {
        float angle = 360 / oneShoting;
        do
        {

            for (int i = 0; i < oneShoting; i++)
            {
                GameObject obj;
                obj = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);


                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * 2 * i / oneShoting), speed * Mathf.Sin(Mathf.PI * i * 2 / oneShoting)));


                obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
            }

            yield return new WaitForSeconds(1f);
        } while (this.GetComponent<EnemyHp>().hp>0 && this.gameObject.activeSelf==true);
    }

}