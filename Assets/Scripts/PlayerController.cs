using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Whale whaleScript;

    public GameObject littleSoundWave;
    public GameObject normalSoundWave;
    public GameObject bigSoundWave;

    GameObject spawned;

    [SerializeField]
    private float soundWaveSpeed;
    [SerializeField]
    private float speed;

    public bool littleWave = true;
    public bool normalWave = false;
    public bool bigWave = false;

    void Start()
    {
        whaleScript = GetComponent<Whale>();
    }

    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        if (littleWave == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 cameraPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
                Vector2 direction = cameraPos - myPos;
                direction.Normalize();

                GameObject spawned = (GameObject)Instantiate(littleSoundWave, transform.position, Quaternion.identity);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

            }
        }
        if (normalWave == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 cameraPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
                Vector2 direction = cameraPos - myPos;
                direction.Normalize();

                GameObject spawned = (GameObject)Instantiate(normalSoundWave, transform.position, Quaternion.identity);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

            }
        }
        if (bigWave == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 cameraPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
                Vector2 direction = cameraPos - myPos;
                direction.Normalize();

                GameObject spawned = (GameObject)Instantiate(bigSoundWave, transform.position, Quaternion.identity);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

            }
        }
        

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (bigWave == true)
            {
                bigWave = false;
                normalWave = true;
            }
            else if (normalWave == true)
            {
                normalWave = false;
                littleWave = true;
            }
            
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (littleWave == true)
            {
                littleWave = false;
                normalWave = true;
            }
            else if (normalWave == true)
            {
                normalWave = false;
                bigWave = true;
            }
        }
    }
}
