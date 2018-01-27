using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawn : MonoBehaviour {

    public GameObject obstacle;

    public float timer;
    public float timeToSpawn;

    // Use this for initialization
    void Start ()
    {
        timer = timeToSpawn;
    }
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Instantiate(obstacle, transform.position, transform.rotation);
            timer = timeToSpawn;
        }
    }
}
