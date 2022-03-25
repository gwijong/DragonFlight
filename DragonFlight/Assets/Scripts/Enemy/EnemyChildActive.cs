using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChildActive : MonoBehaviour
{
    private void OnEnable()
    {
        for(int i = 0; i < 4; i++)
        {
            transform.GetChild(i).gameObject.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
