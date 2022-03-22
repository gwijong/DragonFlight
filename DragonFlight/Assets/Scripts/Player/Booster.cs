using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Booster : MonoBehaviour
{
    public GameObject normalBullet;
    public GameObject busterBullet;
    public GameObject boostBtn;
    public GameObject boostParticle;
    public Text boostText;
    bool isboost = false;
    public int boostCount = 3;

    private void Start()
    {
        boostText.text = boostCount.ToString();
    }
    public void BoosterBtn()
    {
        if (boostCount >= 1)
        {
            boostCount = boostCount - 1;
            boostText.text = boostCount.ToString();
            if (!isboost)
                StartCoroutine("BulletChange");
            isboost = true;
            boostBtn.SetActive(false);
            boostText.enabled = false;
        }
    }
    IEnumerator BulletChange()
    {
        boostParticle.SetActive(true);
        normalBullet.SetActive(false);
        busterBullet.SetActive(true);
        yield return new WaitForSeconds(3.0f);
        normalBullet.SetActive(true);
        busterBullet.SetActive(false);
        isboost = false;
        boostBtn.SetActive(true);
        boostText.enabled = true;
        boostParticle.SetActive(false);
    }
}
