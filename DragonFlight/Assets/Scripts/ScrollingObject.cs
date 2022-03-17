using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 5f;
    public static bool scrollingStop = false;
    void Start()
    {
        
    }

   
    void Update()
    {

        if (gameObject != null)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }

    }
}
