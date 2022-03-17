using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01 : MonoBehaviour
{
    public GameObject BossWarning;
    public GameObject Boss01;
    public GameObject Spawner;
    void Start()
    {
        StartCoroutine("Stage1");
    }


    void Update()
    {
        
    }

    IEnumerator Stage1()
    {
        yield return new WaitForSeconds(30.0f);
        BossWarning.SetActive(true);
        Spawner.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        Boss01.SetActive(true);
        BossWarning.SetActive(false);
        yield return new WaitForSeconds(10.0f);
        Spawner.SetActive(true);
    }
}
