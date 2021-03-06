using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Stage01 : MonoBehaviour
{
    public GameObject BossWarning;
    public GameObject BossWarningLineLeft;
    public GameObject BossWarningLineRight;
    public GameObject Boss01;
    public GameObject Boss02;
    public GameObject Spawner;
    public GameObject[] MeteoSpawner;

    void Start()
    {
        StartCoroutine("Stage1");
    }

    void BossWarningStart()
    {
        BossWarning.SetActive(true);
        BossWarningLineLeft.SetActive(true);
        BossWarningLineRight.SetActive(true);
        Spawner.SetActive(false);
    }

    void BossWarningEnd()
    {
        BossWarningLineLeft.transform.position = new Vector3(BossWarningLineLeft.transform.position.x, 24, BossWarningLineLeft.transform.position.z);
        BossWarningLineRight.transform.position = new Vector3(BossWarningLineRight.transform.position.x, -11.5f, BossWarningLineRight.transform.position.z);
        BossWarningLineLeft.SetActive(false);
        BossWarningLineRight.SetActive(false);
        BossWarning.SetActive(false);
    }

    IEnumerator Stage1()
    {
        yield return new WaitForSeconds(30.0f);
        BossWarningStart();
        for (int i = 1; i < 20; i++)
        {
            BossWarning.GetComponent<RectTransform>().localScale = new Vector3(1, (float)i / 20, 1);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2.0f);
        for (int i = 20; i > 1; i--)
        {
            BossWarning.GetComponent<RectTransform>().localScale = new Vector3(1, (float)i / 20, 1);
            yield return new WaitForSeconds(0.01f);
        }
        BossWarningEnd();      
        yield return new WaitForSeconds(0.5f);
        Boss01.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        Spawner.SetActive(true);
        yield return new WaitForSeconds(10.0f);
        for(int i = 0; i<MeteoSpawner.Length; i++)
        {
            MeteoSpawner[i].SetActive(true);
            yield return new WaitForSeconds(0.4f);
        }
        yield return new WaitForSeconds(10.0f);


        for (int i = 0; i < MeteoSpawner.Length; i++)
        {
            MeteoSpawner[i].SetActive(false);
            yield return new WaitForSeconds(0.4f);
        }

        BossWarningStart();
        BossWarning.transform.GetChild(2).GetComponent<Text>().text = "??????";
        BossWarning.transform.GetChild(4).GetComponent<Text>().text = "???? ?? ???? ????????????.";
        for (int i = 1; i < 20; i++)
        {
            BossWarning.GetComponent<RectTransform>().localScale = new Vector3(1, (float)i / 20, 1);
            yield return new WaitForSeconds(0.01f);
        }
        yield return new WaitForSeconds(2.0f);
        for (int i = 20; i > 1; i--)
        {
            BossWarning.GetComponent<RectTransform>().localScale = new Vector3(1, (float)i / 20, 1);
            yield return new WaitForSeconds(0.01f);
        }
        BossWarningEnd();
        yield return new WaitForSeconds(0.5f);
        Boss02.SetActive(true);

        yield return new WaitForSeconds(8.0f);
        for (int i = 0; i < MeteoSpawner.Length; i++)
        {
            MeteoSpawner[i].SetActive(true);
            yield return new WaitForSeconds(0.4f);
        }
        Spawner.SetActive(true);
    }
}
