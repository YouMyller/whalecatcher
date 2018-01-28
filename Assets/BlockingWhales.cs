using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockingWhales : MonoBehaviour {

    //Kun valas osuu esteeseen, este muuttaa valaan 

    private Whale whaleScript;
    private WhaleQuota whaleQuotaScript;

    private GameObject collidedWhale;
    private GameObject boat;

    private float stunTimeRunning;
    public float stunTime;

    private bool enabledMov = true;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        enabledMov = true;
        stunTimeRunning = stunTime;
        boat = GameObject.FindWithTag("Boat");
        whaleQuotaScript = boat.GetComponent<WhaleQuota>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log(stunTimeRunning);

		if (enabledMov == false)
        {
            stunTimeRunning -= Time.deltaTime;
            //collidedWhale.transform.position += transform.right * Time.deltaTime * whaleScript.moveSpeed;   //might not fit
            if (whaleScript.towardsSound == true)
            {
                collidedWhale.transform.position = Vector3.MoveTowards(collidedWhale.transform.position, -whaleScript.target.position, whaleScript.slowedMoveSpeed * Time.deltaTime);
            }
            else if (whaleScript.towardsSound == false)
            {
                collidedWhale.transform.position += transform.right * Time.deltaTime * whaleScript.moveSpeed / 2;
            }
        }

        if (stunTimeRunning <= 0)
        {
            enabledMov = true;
            whaleScript.enabled = true;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BlueWhale" || collision.gameObject.tag == "KillerWhale" || collision.gameObject.tag == "Narwhal" || collision.gameObject.tag == "SharkWhale")
        {
            whaleQuotaScript.deathMeter -= 5;

            collidedWhale = collision.gameObject;

            whaleScript = collidedWhale.GetComponent<Whale>();
            rb = collidedWhale.GetComponent<Rigidbody2D>();

            whaleScript.enabled = false;
            enabledMov = false;
            stunTimeRunning = stunTime;
        }
    }
}
