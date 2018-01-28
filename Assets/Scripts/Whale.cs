using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whale : MonoBehaviour
{
    public float moveSpeed;

    public Transform target;
    public bool towardsSound = false;
    bool movespeedSlow = false;
    public float slowedMoveSpeed;
    [SerializeField]
    float speedDivider;
    Quaternion ogRotation;
    float rotTime;

    void Start()
    {
        ogRotation = transform.rotation;
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
        if (collision.gameObject.tag == "LittleSoundWave" && gameObject.tag == "KillerWhale")
        {
            Debug.Log("koskettaa");
            towardsSound = true;
        }

        if (collision.gameObject.tag == "NormalSoundWave" && gameObject.tag == "Narwhal")
        {
            towardsSound = true;
        }

        if (collision.gameObject.tag == "BigSoundWave" && gameObject.tag == "BlueWhale")
        {
            towardsSound = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "LittleSoundWave")
        {
            towardsSound = false;
            rotTime = .1f;
        }

        if (collision.gameObject.tag == "NormalSoundWave")
        {
            towardsSound = false;
            rotTime = .1f;
        }

        if (collision.gameObject.tag == "BigSoundWave")
        {
            towardsSound = false;
            rotTime = .1f;
        }
    }

    private void Move()
    {
        if (towardsSound == true)
        {
            movespeedSlow = true;

            if (movespeedSlow == true)
            {
                if (gameObject.tag == "Narwhal")
                {
                    slowedMoveSpeed = moveSpeed - moveSpeed / speedDivider;
                }
                if (gameObject.tag == "KillerWhale")
                {
                    slowedMoveSpeed = moveSpeed - moveSpeed / speedDivider;
                }
                if (gameObject.tag == "BlueWhale")
                {
                    slowedMoveSpeed = moveSpeed / speedDivider;
                }
            }

            /*Vector2 camPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 mouseTarget = camPos - myPos;
            target.Normalize();*/

            Vector2 targetDir = target.transform.position - transform.position;
            //float rotVelocity = moveSpeed * Time.deltaTime;
            float angle = Mathf.Atan2(-targetDir.y, -targetDir.x) * Mathf.Rad2Deg;
            //Vector2 newDir = Vector3.RotateTowards(-transform.right, targetDir, rotVelocity, 0.0F);
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

            transform.position = Vector3.MoveTowards(transform.position, target.position, slowedMoveSpeed * Time.deltaTime);
            //transform.LookAt(target);
        }

        if (towardsSound == false)
        {
            rotTime -= Time.deltaTime;
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;

            if (rotTime <= 0)
            {
                transform.rotation = ogRotation;
            }
        }
        
    }
}
