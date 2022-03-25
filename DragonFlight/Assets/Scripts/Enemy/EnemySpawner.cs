using UnityEditor;
using UnityEngine;

public class EnemySpawner : MonoBehaviour  
{
    public GameObject enemyPrefab;  
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
        if (enemyPrefab != null)
        {
            Enemy = new GameObject[count];

            for (int i = 0; i < count; i++)
            {
                Enemy[i] = Instantiate(enemyPrefab, poolPosition, Quaternion.identity);
                for (int j = 0; j < 4; j++)
                {
                    EnemyHp enemyhp = Enemy[i].transform.GetChild(j).GetComponent<EnemyHp>();
                    Animator animator = Enemy[i].transform.GetChild(j).GetComponent<Animator>();
              
                    switch (Random.Range(0, 4))
                    {
                        case (int)EnemyList.White:
                            enemyhp.maxhp = 1;
                            enemyhp.hp = 1;
                            break;
                        case (int)EnemyList.Blue:
                            enemyhp.maxhp = 15;
                            enemyhp.hp = 15;
                            animator.runtimeAnimatorController = (RuntimeAnimatorController)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Enemy01/Enemy03_0.controller", typeof(RuntimeAnimatorController));
                            break;
                        case (int)EnemyList.Gold:
                            enemyhp.maxhp = 40;
                            enemyhp.hp = 40;
                            animator.runtimeAnimatorController = (RuntimeAnimatorController)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Enemy01/Enemy04_0.controller", typeof(RuntimeAnimatorController));
                            break;
                        case (int)EnemyList.Red:
                            enemyhp.maxhp = 100;
                            enemyhp.hp = 100;
                            animator.runtimeAnimatorController = (RuntimeAnimatorController)AssetDatabase.LoadAssetAtPath("Assets/Sprites/Enemy01/Enemy02_0.controller", typeof(RuntimeAnimatorController));
                            break;
                    }
                }
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

