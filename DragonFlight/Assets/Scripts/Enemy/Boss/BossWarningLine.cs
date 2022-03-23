using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossWarningLine : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.Translate(0, 1 * speed * Time.deltaTime, 0);
    }
}
