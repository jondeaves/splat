using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ThrowObject : MonoBehaviour {

    public GameObject Target;
    public GameObject ThrowableObject;


	// Use this for initialization
	void Start () {
	}

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //PerformThrowObject();
        }

        if(transform.tag == "Player")
        {
            if(Input.GetKeyUp(KeyCode.Space))
            {
                PerformThrowObject();
            }
        }
        else if(Target != null)
        {
            float distanceToTarget = Vector2.Distance(this.transform.position, Target.transform.position);
            if (distanceToTarget < 900f)
            {
                PerformThrowObject();
            }
        }

    }

    void PerformThrowObject()
    {

        if (ThrowableObject != null)
        {
            GameObject tmpObject = GameObject.Instantiate(ThrowableObject) as GameObject;
            tmpObject.transform.parent = transform;
            tmpObject.transform.localPosition = Vector3.zero;


            Vector2 direction = Vector2.zero;
            if (this.Target != null)
            {
                direction = Vector2.MoveTowards(tmpObject.transform.position, Target.transform.position, 1000f) * Time.deltaTime;
                direction.Normalize();
            }
            else
            {
                direction = new Vector2(1, 0);
                direction.Normalize();
            }

            tmpObject.rigidbody2D.AddForce(direction * 100f);
            ThrowableObject = null;
        }

    }
}


