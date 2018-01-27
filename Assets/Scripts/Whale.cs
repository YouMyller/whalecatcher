using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    public GameObject whale;

    [SerializeField]
    private float moveSpeed;

    public Transform target;
    bool towardsSound = false;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "SoundWave")
        {
            Debug.Log("koskettaa");
            towardsSound = true;
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

            transform.position = Vector3.MoveTowards(transform.position, target.position, slowedMoveSpeed * Time.deltaTime);
        }

        else
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        
    }
}
