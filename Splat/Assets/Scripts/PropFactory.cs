using UnityEngine;
using System.Collections;

public class PropFactory : MonoBehaviour {

    public GameObject[] Props;
    public Spawner[] Spawners;


    public void SpawnInProps(int amount)
    {
        for (int i = 0; i < amount; i++)
        {
            Spawners[Random.Range(0, Spawners.Length - 1)].AddToSpawnQueue(Props[Random.Range(0, Props.Length - 1)]);
        }
    }

}
