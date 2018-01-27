using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Whale whaleSript;

    public GameObject soundWave;
    GameObject spawned;

    [SerializeField]
    private float soundWaveSpeed;
    [SerializeField]
    private float speed;
    //Rigidbody2D rb;

    private void Awake()
    {
        spawned = Instantiate(soundWave, transform.position, transform.rotation);
        spawned.SetActive(false);
    }

    void Start()
    {
        whaleSript = GetComponent<Whale>();
        //rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        /*if (Input.GetMouseButtonUp(0))
        {
            Debug.Log("Button up");
            whaleSript.towardsSound = false;
        }*/

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

            
            spawned.SetActive(true);


        }

        if (Input.GetMouseButton(0))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 direction = target - myPos;
            direction.Normalize();

            Vector3 targetDir = direction;
            float step = speed * Time.deltaTime;
            Vector3 newDir = Vector3.RotateTowards(spawned.transform.forward, targetDir, step, 0.0F);
            Debug.DrawRay(transform.position, newDir, Color.red);
            spawned.transform.rotation = Quaternion.LookRotation(newDir);

        }

        if (Input.GetMouseButtonUp(0))
        {
            spawned.SetActive(false);
        }
    }
}
