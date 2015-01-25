using UnityEngine;
using System.Collections;

public class EnemyFactory : MonoBehaviour {

    public GameObject[] Enemys;
    public Spawner[] Spawners;


    public void SpawnInEnemy(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Spawners[Random.Range(0, Spawners.Length)].AddToSpawnQueue(Enemys[Random.Range(0, Enemys.Length)]);
        }
    }
}
