using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //FindObjectOfType<PropFactory>().MassSpawnProps();
            //FindObjectOfType<EnemyFactory>().MassSpawnEnemy();
            
            //Game.GameOver(false);
            //Destroy(this);
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            foreach (Clouds cloud in FindObjectsOfType<Clouds>())
            {
                cloud.enabled = false;
            }
        }
    }
}
