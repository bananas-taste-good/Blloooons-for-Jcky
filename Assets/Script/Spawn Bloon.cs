using UnityEngine;

public class SpawnBloon : MonoBehaviour
{
    public Transform startingPoint;
    public float spawnDelay;
    public float spawnTimer;

    public int wave;
    public int maxWave;

    public int[] bloonSpawns;
    public GameObject[] bloonPrefab;
    private int currentIndex;

    private void start()
    {
        currentIndex = 0;
        wave = 1;
        spawnTimer = 0f;
    }
    
    private void Update()
    {
        spawnTimer += Time.deltaTime;
        if(spawnTimer > spawnDelay)
        {
            spawnTimer = 0f;
            if (currentIndex < bloonSpawns.Length)
            {
                GameObject bloon;
                bloon = GameObject.Instantiate(bloonPrefab[bloonSpawns[currentIndex]]);
                bloon.transform.position = startingPoint.position;
                currentIndex++;
            }
        }
    }
}
