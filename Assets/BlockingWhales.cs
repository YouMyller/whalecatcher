using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingWhales : MonoBehaviour {

    //Kun valas osuu esteeseen, este muuttaa valaan 

    private Whale whaleScript;

    private GameObject collidedWhale;

    private float stunTimeRunning;
    public float stunTime;

    private bool enabledMov = true;

    public Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        enabled = true;
        stunTimeRunning = stunTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        Debug.Log(stunTimeRunning);

		if (enabledMov == false)
        {
            stunTimeRunning -= Time.deltaTime;
            //collidedWhale.transform.position -= transform.forward * Time.deltaTime * whaleScript.moveSpeed;   TÄHÄN JÄÄTIIN
        }

        if (stunTimeRunning <= 0)
        {
            whaleScript.enabled = true;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "BlueWhale" || collision.gameObject.tag == "KillerWhale" || collision.gameObject.tag == "Narwhal" || collision.gameObject.tag == "SharkWhale")
        {
            collidedWhale = collision.gameObject;

            whaleScript = collidedWhale.GetComponent<Whale>();

            whaleScript.enabled = false;
            enabledMov = false;
            stunTimeRunning = stunTime;
        }
    }
}
