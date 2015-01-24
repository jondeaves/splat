using UnityEngine;
using System.Collections;

public class Arrow : MonoBehaviour {
    public bool IsTop = false;
    public Transform Target;

    Transform player;
    float distanceFromPlayer;

	void Start () {
        player = Game.PlayerBody.transform;
        distanceFromPlayer = transform.position.y - player.position.y;
	}

    void ToggleActive()
    {
        if (IsTop)
        {
            if (Target.position.y > Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0)).y)
            {
                renderer.enabled = true;
            }
            else
            {
                renderer.enabled = false;
            }
        }
        else
        {
            if (Target.position.y < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).y)
            {
                renderer.enabled = true;
            }
            else
            {
                renderer.enabled = false;
            }
        }
    }

    void UpdatePos()
    {
        Vector3 newPos = transform.position;
        newPos.x = Target.position.x;
        newPos.y = player.position.y + distanceFromPlayer;
        transform.position = newPos;
    }

	void Update () 
    {
        ToggleActive();
        UpdatePos();
	}
}
