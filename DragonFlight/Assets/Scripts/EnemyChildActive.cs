using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChildActive : MonoBehaviour
{
    public GameObject[] Enemys;
    private void OnEnable()
    {
        for(int i = 0; i < Enemys.Length; i++)
        {
            Enemys[i].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
