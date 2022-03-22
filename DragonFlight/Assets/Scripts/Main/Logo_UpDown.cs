using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo_UpDown : MonoBehaviour
{

    float time = 0;
    void Start()
    {
        
    }


    void Update()
    {
        time = time + Time.deltaTime;

        if(time>=0 && time < 1)
        {
            this.transform.Translate(0, 1 * Time.deltaTime, 0);
        }
        else if (time >= 1 && time < 2)
        {
            this.transform.Translate(0, -1 * Time.deltaTime, 0);
        }
        if (time >= 2)
        {
            time = 0;
        }
    }
}
