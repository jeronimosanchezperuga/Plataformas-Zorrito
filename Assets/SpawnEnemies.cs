using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField]
    GameObject enemyPrefab;
    [SerializeField]
    Transform spawnPointTR;
    public bool autoSpawn = false;
    public bool randomPosition = false;
    public float spawnInterval=1f;
    [SerializeField]
    float elapsedTime;
    [SerializeField]
    float nextSpawnTime=0;
    [SerializeField]
    private Vector2 topLefLimit;
    [SerializeField]
    private Vector2 bottomRightLimit;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = spawnInterval;
        if (!spawnPointTR)
        {
            randomPosition = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (autoSpawn)
        {
            elapsedTime += Time.deltaTime;
            if(elapsedTime > nextSpawnTime){
                if (randomPosition)
                {
                    CloneENemyAtRandomPosition();
                }
                else
                {
                    CloneEnemy(spawnPointTR);
                }
                
                nextSpawnTime = elapsedTime + spawnInterval;
            }
        }
    }

    public void CloneEnemy(Transform point)
    {
        GameObject clon = Instantiate(enemyPrefab, point.position, Quaternion.identity);
    }
    public void CloneENemyAtRandomPosition()
    {
        GameObject clon = Instantiate(enemyPrefab, RandomVector2InBounds(topLefLimit,bottomRightLimit), Quaternion.identity);
    }

    public Vector2 RandomVector2InBounds(Vector2 topLeft, Vector3 bottomRight)
    {
        float x = Random.Range(topLeft.x,bottomRight.x);
        float y = Random.Range(bottomRight.y,topLeft.y);
        return new Vector2(x,y); ;
    }
}
