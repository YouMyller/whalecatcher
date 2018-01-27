using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClawGrab : MonoBehaviour {

    public Transform target;
    public Transform targetBack;
    public Transform grabber;

    public bool move = false;

    public float moveSpeed = 5;
    public float whaleGrabSpeed;
    private float velocity;
    private float whaleGrabVelocity;

    private GameObject whale;
   // public float moveTime;
   
    //public float beginTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = moveSpeed * Time.deltaTime;
        whaleGrabVelocity = whaleGrabSpeed * Time.deltaTime;

        if (move == true)
        {
            whale.transform.position = Vector3.MoveTowards(whale.transform.position, grabber.position, whaleGrabVelocity);

            transform.position = Vector3.MoveTowards(transform.position, target.position, velocity);

            if (transform.position == target.position)
            {
                move = false;
            }
        }

        if (move == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetBack.position, velocity);
            move = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BlueWhale" || collision.gameObject.tag == "KillerWhale" || collision.gameObject.tag == "Narwhal" || collision.gameObject.tag == "SharkWhale")
        {
            move = true;
            //moveTime = beginTime;
            if (collision.gameObject.tag == "BlueWhale")
            {
                collision.gameObject.tag = "NullBlue";
            }
            if (collision.gameObject.tag == "KillerWhale")
            {
                collision.gameObject.tag = "NullKiller";
            }
            if (collision.gameObject.tag == "Narwhal")
            {
                collision.gameObject.tag = "NullNar";
            }
            if (collision.gameObject.tag == "SharkWhale")
            {
                collision.gameObject.tag = "NullShark";
            }

            whale = collision.gameObject;

            //Collider whaleCollision = whale.GetComponent<Collider>();

            //whaleCollision.isTrigger = true;
        }
    }
}
