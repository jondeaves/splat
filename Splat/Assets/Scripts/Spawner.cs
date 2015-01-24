using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

    const float minTimeBetweenSpawns = 2f;
    const float maxTimeBetweenSpawns = 5f;

    public Vector2 Force = Vector3.zero;
    IList<GameObject> spawnQueue = new List<GameObject>();
    float timeSinceLastSpawn = 0;
    float timeTillNextSpawn = 0;
    Rigidbody2D PlayerBody;

    void Start()
    {
        SetTimeTillNextSpawn();
        PlayerBody = Game.PlayerBody.rigidbody2D;
    }

    public void AddToSpawnQueue(GameObject obj)
    {
        spawnQueue.Add(obj);
    }

    void SetTimeTillNextSpawn()
    {
        timeTillNextSpawn = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
    }

    void Spawn()
    {
        GameObject newObj = Instantiate(spawnQueue[0]) as GameObject;
        spawnQueue.RemoveAt(0);

        newObj.transform.position = transform.position;
        newObj.rigidbody2D.velocity = PlayerBody.velocity;

        if (newObj.name.Contains("Enemy"))
        {
            newObj.rigidbody2D.AddForce(new Vector2(0, -800f));
        }
        newObj.rigidbody2D.AddForce(Force);
        Game.NumberOfProps++;
        timeSinceLastSpawn = 0;
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;
        if(spawnQueue == null || spawnQueue.Count < 1)
        {
            return;
        }

        if (timeSinceLastSpawn >= timeTillNextSpawn)
        {
            Spawn();
        }
    }
}
