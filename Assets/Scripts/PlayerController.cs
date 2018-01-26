using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject soundWave;

    [SerializeField]
    private float soundWaveSpeed;

    //Rigidbody2D rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Painaa mouse");
            /*
            var mousePos = Input.mousePosition;
            var objectPos = Camera.current.ScreenToWorldPoint(mousePos);
            Instantiate(soundWave, objectPos, Quaternion.identity);

            Vector3 sp = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 dir = (Input.mousePosition - sp).normalized;
            rb.AddForce(dir * 2);
            GameObject spawned = Instantiate(soundWave, dir, transform.rotation);
            spawned.GetComponent<Rigidbody2D>().AddForce(new Vector2(dir, dir));*/

            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 direction = target - myPos;
            direction.Normalize();
            GameObject spawned = (GameObject)Instantiate(soundWave, myPos, Quaternion.identity);
            spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

        }
    }
}
