using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Die_Chack : MonoBehaviour
{
    public GameObject cragon;
    int allSlimeHpCheck;
    bool flag1 = false;
    bool flag2 = false;

    void Update()
    {
        if (cragon.activeSelf == true)
        {
            flag1 = true;
        }

        if (flag1 == true)
        {

            if (cragon.GetComponent<EnemyHp>().hp<= 0 && flag2 == false)
            {
                flag2 = true;
                GameManager.instance.victory = true;
                flag1 = false;
            }
        }
    }
}
