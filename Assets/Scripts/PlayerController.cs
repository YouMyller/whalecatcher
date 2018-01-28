using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Whale whaleScript;

    public GameObject littleSoundWave;
    public GameObject normalSoundWave;
    public GameObject bigSoundWave;

    [SerializeField]
    private float soundWaveSpeed;
    [SerializeField]
    private float speed;

    public bool littleWave = false;
    public bool normalWave = true;
    public bool bigWave = false;

    public Transform shootPoint;

    /*public float timerTime;
    public float time = 10f;
    */

    public GameObject dial;
    public Transform target;

    public AudioSource clickSound;
    public AudioSource soundSound;

    void Start()
    {
        whaleScript = GetComponent<Whale>();
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            soundSound.Stop();
        }

        if (littleWave == true)
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 cameraPos = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
                Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
                Vector2 direction = cameraPos - myPos;
                direction.Normalize();

                if (!soundSound.isPlaying && Input.GetMouseButton(0))
                {
                    soundSound.Play();
                    soundSound.pitch = 1.1f;
                }

                /*else if (bigWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = .8f;
                }

                else if (normalWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = 1;
                }*/

                GameObject spawned = (GameObject)Instantiate(littleSoundWave, shootPoint.position, Quaternion.identity);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

                /*timerTime = time + Time.deltaTime;
                spawned.transform.localScale += new Vector3(0.1F, 100, 0);
                spawned.transform.localScale += new Vector3(0.1F, 5, 0);
                */

                Destroy(spawned, 2);
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

                if (!soundSound.isPlaying && Input.GetMouseButton(0))
                {
                    soundSound.Play();
                    soundSound.pitch = 1;
                }

                /*else if (bigWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = .8f;
                }

                else if (littleWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = 1.5f;
                }*/

                GameObject spawned = (GameObject)Instantiate(normalSoundWave, shootPoint.position, Quaternion.identity);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

                Destroy(spawned, 2);
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

                if (!soundSound.isPlaying && Input.GetMouseButton(0))
                {
                    soundSound.Play();
                    soundSound.pitch = .8f;
                }
                /*else if (normalWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = 1;
                }
                else if (littleWave == true && Input.GetMouseButton(0))
                {
                    soundSound.pitch = 1.5f;
                }
                */
                GameObject spawned = (GameObject)Instantiate(bigSoundWave, shootPoint.position, transform.rotation);
                spawned.GetComponent<Rigidbody2D>().velocity = direction * 50;

                Destroy(spawned, 2);
            }
        }
        

        if (Input.GetKeyDown(KeyCode.X))
        {
            if (bigWave == true)
            {
                bigWave = false;
                normalWave = true;

                if (normalWave == true)
                {
                    clickSound.Play();
                }

                /*
                Vector3 targetDir = .position - transform.position;
                float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90f;
                Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
                */

                dial.transform.Rotate(Vector3.back * 90);

            }
            else if (normalWave == true)
            {
                normalWave = false;
                littleWave = true;

                if (littleWave == true)
                {
                    clickSound.Play();
                    soundSound.pitch = 1.1f;
                }

                dial.transform.Rotate(Vector3.back * 90);
            }
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (littleWave == true)
            {
                littleWave = false;
                normalWave = true;

                if (normalWave == true)
                {
                    clickSound.Play();
                    soundSound.pitch = 1;
                }

                dial.transform.Rotate(Vector3.forward * 90);
            }
            else if (normalWave == true)
            {
                normalWave = false;
                bigWave = true;

                if (bigWave == true)
                {
                    clickSound.Play();
                    soundSound.pitch = .8f;
                }

                dial.transform.Rotate(Vector3.forward * 90);
            }
        }
    }
}
