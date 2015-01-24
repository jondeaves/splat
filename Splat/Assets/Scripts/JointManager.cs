using UnityEngine;
using System.Collections;

public class JointManager : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Player")
        {
            Destroy(GetComponent<Joint2D>());
        }
    }
}
