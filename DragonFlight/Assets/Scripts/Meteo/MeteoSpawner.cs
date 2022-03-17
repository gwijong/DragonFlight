using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoSpawner : MonoBehaviour
{
    public GameObject meteo;
    public GameObject WarningLine;

    float time = 0;
    bool flag1 = false;

    public float height = -20.0f;
    GameObject war;
    void Start()
    {
        time = time - 10.0f;
    }

    void Update()
    {
        time = time + Time.deltaTime;
        if (time >= 0)
        {
            if (flag1 == false)
            {
                flag1 = true;
                war = Instantiate(WarningLine);
                war.transform.position = new Vector3(this.transform.position.x,this.transform.position.y+height, this.transform.position.z);
            }

            if (time >= 2)
            {
                time = -12;
                GameObject met = Instantiate(meteo);
                met.transform.position = war.transform.position;
                war.SetActive(false);
                flag1=false;
            }
        }
    }
}
