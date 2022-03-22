using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy_HpBar : MonoBehaviour
{
    public GameObject Slime;
    public Image hpBar;
    public Image backHpBar;
    public float yPos = -3;
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        hpBar.fillAmount = (float)gameObject.GetComponent<EnemyHp>().hp / gameObject.GetComponent<EnemyHp>().maxhp;

        hpBar.rectTransform.position = Camera.main.WorldToScreenPoint(Slime.transform.position+ new Vector3 (0, yPos, 0));
        backHpBar.rectTransform.position = Camera.main.WorldToScreenPoint(Slime.transform.position + new Vector3(0, yPos, 0));
    }
}