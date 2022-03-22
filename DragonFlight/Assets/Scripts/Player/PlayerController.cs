using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 mousePos2;
    Vector3 pos;
    Vector3 pos2;
    Vector3 posDistance;
    float moveRange = 3f;
    void Update()
    {
        if(GameManager.instance.isGameover == true)
        {
            return;
        }
        Move();

    }

    private void Move()
    {
        if (Input.GetMouseButtonDown(0) && Input.touchCount<=1)
        {
            mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            pos = Camera.main.ScreenToWorldPoint(mousePos);
            posDistance = this.transform.position - pos;
        }

        if (Input.GetMouseButton(0) && Input.touchCount <= 1)
        {
            mousePos2 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            pos2 = Camera.main.ScreenToWorldPoint(mousePos2);

            if (
                (Camera.main.ScreenToWorldPoint(mousePos2) + posDistance).x < moveRange &&
                (Camera.main.ScreenToWorldPoint(mousePos2) + posDistance).x > -moveRange &&
                (Camera.main.ScreenToWorldPoint(mousePos2) + posDistance).y < moveRange * 1.5 &&
                (Camera.main.ScreenToWorldPoint(mousePos2) + posDistance).y > -moveRange * 2.2f
               )
            {
                this.transform.position = new Vector3((Camera.main.ScreenToWorldPoint(mousePos2) + posDistance).x, this.transform.position.y,0);
            }
        }
    }
}
