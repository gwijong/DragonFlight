using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoSpawner : MonoBehaviour
{
    public GameObject meteo;
    public GameObject WarningLine;

    float time = 0;
    float time2 = 0;
    bool flag1 = false;

    public float height = -20.0f;
    GameObject war;
    float speed = 1;

    private void OnEnable()
    {
        time = Random.Range(-10.0f, -7.0f);
        speed = Random.Range(-0.8f, 0.8f);
    }


    void Update()
    {
        SpawnerPosMove();
        MeteoAttack();
    }

    void SpawnerPosMove()
    {
        time2 = time2 + Time.deltaTime;
        if (time2 <= 2)
        {
            this.transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        }
        else if (time2 > 2 && time2 <= 4)
        {
            this.transform.Translate(-1 * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            time2 = 0;
        }
    }
    void MeteoAttack()
    {
        time = time + Time.deltaTime;
        if (time >= 0)
        {
            if (flag1 == false)
            {
                flag1 = true;
                war = Instantiate(WarningLine);
                war.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + height, this.transform.position.z);
            }

            if (time >= 2)
            {
                time = -12;
                GameObject met = Instantiate(meteo);
                met.transform.position = war.transform.position + new Vector3(0, 2, 0);
                Destroy(war, 0.1f);
                flag1 = false;
            }
        }
    }
}
