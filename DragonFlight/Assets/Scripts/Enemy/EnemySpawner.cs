using UnityEngine;

public class EnemySpawner : MonoBehaviour  
{
    public GameObject platformPrefab;  
    public int count = 3;  

    float timeBetSpawnMin = 2f;  
    float timeBetSpawnMax = 4f;  
    float timeBetSpawn;  

    public float ypos = 5f;  

    public float xMin = -5f;  
    public float xMax = 5f;

    GameObject[] Enemy;
    int currentIndex = 0;  

    Vector2 poolPosition = new Vector2(-150, -25);  
    float lastSpawnTime;  

    void Start()  
    {
        if (platformPrefab != null)
        {
            Enemy = new GameObject[count];

            for (int i = 0; i < count; i++)
            {
                Enemy[i] = Instantiate(platformPrefab, poolPosition, Quaternion.identity);
            }
        }
        lastSpawnTime = 0f;
    }

    void Update()  
    {
        SpawnDragon();
    }

    void SpawnDragon()
    {
        if (Time.time > lastSpawnTime + timeBetSpawn)
        {
            lastSpawnTime = Time.time;
            timeBetSpawn = Random.Range(timeBetSpawnMin, timeBetSpawnMax);
            float xPos = Random.Range(xMin, xMax);
            Enemy[currentIndex].SetActive(false);
            Enemy[currentIndex].SetActive(true);
            Enemy[currentIndex].transform.position = new Vector2(xPos, ypos);
            currentIndex++;
            if (currentIndex >= count)
            {
                currentIndex = 0;
            }
        }
    }
}
