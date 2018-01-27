using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NullWhaleKiller : MonoBehaviour {

    public float killTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (gameObject.tag == "Null")
        {
            killTime -= Time.deltaTime;
        }

        if (killTime <= 0)
        {
            Destroy(gameObject);
        }
	}
}
