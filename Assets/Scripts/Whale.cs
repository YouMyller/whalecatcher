using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    public GameObject whale;

    [SerializeField]
    private float moveSpeed;

    public Transform target;
    public bool towardsSound = false;
    bool movespeedSlow = false;
    [SerializeField]
    private float slowedMoveSpeed;

    void Start()
    {

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SoundWave")
        {
            Debug.Log("koskettaa");
            towardsSound = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SoundWave")
        {
            Debug.Log("ei kosketa enää");
            towardsSound = false;
        }
    }

    private void Move()
    {
        if (towardsSound == true)
        {
            movespeedSlow = true;

            if (movespeedSlow == true)
            {
                slowedMoveSpeed = moveSpeed - 2;
            }

            /*Vector2 camPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 mouseTarget = camPos - myPos;
            target.Normalize();*/

            transform.position = Vector3.MoveTowards(transform.position, target.position, slowedMoveSpeed * Time.deltaTime);
        }

        if (towardsSound == false)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        
    }
}
