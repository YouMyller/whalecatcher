using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

    public float[] moveSpeeds;
    public float currentSpeed;
    public float deathTimer;

	// Use this for initialization
	void Start ()
    {
        currentSpeed = moveSpeeds[Random.Range(0, moveSpeeds.Length)];
	}
	
	// Update is called once per frame
	void Update ()
    {
        deathTimer -= Time.deltaTime;

        transform.position += Vector3.left * currentSpeed * Time.deltaTime;

        /*if (deathTimer <= 0)
        {
            Destroy(gameObject);
        }*/
    }
}
