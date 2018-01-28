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
    public GameObject claw;

    public Sprite normalSprite;
    public Sprite grabbingSprite;

    public AudioSource grabSound;
    public GameObject clawMoveSoundPlayer;
    private ClawMoveSound clawMoveSound;
    private AudioSource moveSoundSource;
    public float grabSoundTime;

    // public float moveTime;

    //public float beginTime;

    // Use this for initialization
    void Start ()
    {
        claw.GetComponent<SpriteRenderer>().sprite = normalSprite;
        clawMoveSound = clawMoveSoundPlayer.GetComponent<ClawMoveSound>();
        moveSoundSource = clawMoveSound.movingSound;
	}
	
	// Update is called once per frame
	void Update ()
    {
        velocity = moveSpeed * Time.deltaTime;
        whaleGrabVelocity = whaleGrabSpeed * Time.deltaTime;

        if (move == true)
        {
            if (!clawMoveSound.movingSound.isPlaying)
            {
                clawMoveSound.movingSound.Play();
            }

            claw.GetComponent<SpriteRenderer>().sprite = grabbingSprite;

            whale.transform.position = Vector3.MoveTowards(whale.transform.position, grabber.position, whaleGrabVelocity);

            transform.position = Vector3.MoveTowards(transform.position, target.position, velocity);

            grabSoundTime -= Time.deltaTime;

            if (!grabSound.isPlaying && grabSoundTime <= 0)
            {
                grabSound.Play();
                grabSoundTime = 2;
            }

            if (transform.position == target.position)
            {
                move = false;
            }
        }

        if (move == false)
        {
            grabSoundTime = 0;
            claw.GetComponent<SpriteRenderer>().sprite = normalSprite;
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
