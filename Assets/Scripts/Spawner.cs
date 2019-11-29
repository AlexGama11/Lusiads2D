using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] obstaclePatterns;

    private float TimeBtwSpawn;
    public float StartTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    void Update()
    {
        if (TimeBtwSpawn <= 0)
        {
            int rand = Random.Range(0, obstaclePatterns.Length);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            TimeBtwSpawn = StartTimeBtwSpawn;
            if (StartTimeBtwSpawn > minTime)
            {
                StartTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            TimeBtwSpawn -= Time.deltaTime;
        }
    }
}
