using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject soundWave;
    GameObject spawned;

    [SerializeField]
    private float soundWaveSpeed;
    [SerializeField]
    private float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 cameraPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 direction = cameraPos - myPos;
            direction.Normalize();

            GameObject spawned = (GameObject)Instantiate(soundWave, transform.position, Quaternion.identity);
            spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

        }
    }
}
