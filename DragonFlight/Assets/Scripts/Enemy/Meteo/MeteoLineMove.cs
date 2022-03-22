using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteoLineMove : MonoBehaviour
{
    public GameObject particle;
    float tm = 0;
    GameObject player;
    public float speed = 0.01f;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        StartCoroutine("ParticleBlink");
    }

    // Update is called once per frame
    void Update()
    {

        float x = (player.transform.position.x - this.transform.position.x);
        this.transform.Translate(x * speed * Time.deltaTime, 0, 0);
        if (gameObject.activeSelf== true)
        {
            tm = tm + Time.deltaTime;
            if (tm >= 2.1f)
            {
                gameObject.SetActive(false);
            }
        }
    }

    IEnumerator ParticleBlink()
    {
        particle.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.3f);
        particle.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        particle.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        particle.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        particle.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        particle.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        particle.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        particle.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.1f);
        particle.gameObject.SetActive(true);
    }
}
