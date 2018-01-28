using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundRotation : MonoBehaviour {

    //Quaternion rot;
    private GameObject rotator;

	// Use this for initialization
	void Start ()
    {
        //transform.Rotate(Vector3.forward * -90);
        //rot = transform.rotation;
        rotator = GameObject.FindWithTag("Rotator");
        transform.rotation = rotator.transform.rotation;
    }
	
	// Update is called once per frame
	void Update ()
    {

        /*Vector2 targetDir = Input.mousePosition - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.right);*/
    }
}
