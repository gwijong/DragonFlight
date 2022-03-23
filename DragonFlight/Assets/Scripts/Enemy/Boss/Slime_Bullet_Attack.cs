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

    IEnumerator SpellStart()
    {
        do
        {
            yield return new WaitForSeconds(Random.Range(0.5f,2f));
            float currentAngle = 247.5f;
            for (int i = 0; i < oneShoting; i++)
            {
                GameObject obj;
                obj = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);
                obj.transform.parent = this.transform;

                obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed * Mathf.Cos(Mathf.PI * (currentAngle / 180.0f)), speed * Mathf.Sin(Mathf.PI * (currentAngle / 180.0f))));

                currentAngle += 45.0f / (oneShoting - 1);
                //obj.transform.Rotate(new Vector3(0f, 0f, 360 * i / oneShoting - 90));
            }

            yield return new WaitForSeconds(2f);
            oneShoting++;
        } while (this.GetComponent<EnemyHp>().hp>0 && this.gameObject.activeSelf==true);
    }

}
