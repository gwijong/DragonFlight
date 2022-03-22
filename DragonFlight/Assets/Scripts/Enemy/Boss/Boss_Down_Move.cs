using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Down_Move : MonoBehaviour
{
    float tm = 0;
    public float speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true && tm<1f)
        {
            tm = tm + Time.deltaTime;
            transform.Translate(0, -1 * speed * Time.deltaTime, 0);
        }
    }
}
