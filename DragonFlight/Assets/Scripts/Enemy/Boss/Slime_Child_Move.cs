using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Child_Move : MonoBehaviour
{
    public float speed = 1;
    float time = 0;

    void Update()
    {
        if(gameObject.activeSelf == true && time<=0.5f)
        {
            time = time + Time.deltaTime;
            this.transform.Translate(1*speed*Time.deltaTime, 0, 0);
        }
    }
}
