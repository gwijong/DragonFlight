using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_Clear_Check : MonoBehaviour
{
    public GameObject[] slimes;
    public GameObject bossSlime;
    int allSlimeHpCheck;
    bool flag1 = false;
    bool flag2 = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (bossSlime.activeSelf == true)
        {
            flag1 = true;
        }

        if(flag1 == true)
        {
            for (int i = 0; i < slimes.Length; i++)
            {
                allSlimeHpCheck += slimes[i].GetComponent<EnemyHp>().hp;
            }
            if (allSlimeHpCheck > 0)
            {
                allSlimeHpCheck = 0;
                return;
            }
            else if(allSlimeHpCheck<=0 && flag2 ==false)
            {
                flag2 = true;
                GameManager.instance.victory = true;
            }
        }


    }
}
