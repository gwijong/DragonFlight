using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage01 : MonoBehaviour
{
    public GameObject BossWarning;
    public GameObject BossWarningLineLeft;
    public GameObject BossWarningLineRight;
    public GameObject Boss01;
    public GameObject Spawner;
    public GameObject[] MeteoSpawner;
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
        BossWarningLineLeft.SetActive(true);
        BossWarningLineRight.SetActive(true);
        Spawner.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        Boss01.SetActive(true);
        BossWarning.SetActive(false);
        BossWarningLineLeft.SetActive(false);
        BossWarningLineRight.SetActive(false);
        yield return new WaitForSeconds(10.0f);
        Spawner.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        for(int i = 0; i<MeteoSpawner.Length; i++)
        {
            MeteoSpawner[i].SetActive(true);
            yield return new WaitForSeconds(0.4f);
        }

    }
}
