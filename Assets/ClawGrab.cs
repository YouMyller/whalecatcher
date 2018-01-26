using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawGrab : MonoBehaviour {

    public bool rotate = false;

    public float rotationSpeed = 5;
    public float rotationTime;
    public float beginTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (rotate == true)
        {
            rotationTime -= Time.deltaTime;
            transform.Rotate(Vector3.forward * rotationSpeed);
            //make the object rotate with the claw
            if (rotationTime <= 0)
            {
                rotate = false;
            }
        }
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BlueWhale" || collision.gameObject.tag == "KillerWhale" || collision.gameObject.tag == "Narwhal")
        {
            rotate = true;
            rotationTime = beginTime;
            collision.gameObject.tag = "Null";
        }
    }
}
