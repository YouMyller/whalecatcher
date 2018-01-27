using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour {

    public float timer;
    public float timeToSpawn;

    public GameObject[] whales;
    public int blueWhales;
    public int narWhals;
    public int sharkWhales;
    public int killerWhales;
    public int all;

    private bool beginning = true;
    private bool dontSpawnBlue = false;
    private bool dontSpawnNarwhal = false;
    private bool dontSpawnKiller = false;
    private bool dontSpawnShark = false;
    private bool pleaseStop = false;

    // Use this for initialization
    void Start ()
    {
        timer = timeToSpawn;
        beginning = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;

        WhaleCount();

        if (timer <= 0)
        {
            if (beginning == true)
            {
                Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
                else
                {
                    int val = Random.Range(0, whales.Length);

                    if (val == 0)
                    {
                        BlueCreate();
                    }

                    if (val == 1)
                    {
                        NarCreate();
                    }

                    if (val == 2)
                    {
                        KillerCreate();
                    }

                    if (val == 3)
                    {
                        SharkCreate();
                    }
            }
            
            /*else if (dontSpawnBlue == true && dontSpawnNarwhal == true)
            {
                int val = Random.Range(0, whales.Length);

                if (val == 0)
                {
                    val += 2;
                }

                if (val == 1)
                {
                    val += 1;
                }

                Instantiate(whales[val], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
            else if (dontSpawnNarwhal == true && dontSpawnKiller == true)
            {
                int val = Random.Range(0, whales.Length);

                if (val == 1)
                {
                    val += 2;
                }

                if (val == 2)
                {
                    val += 1;
                }

                Instantiate(whales[val], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
            else if (dontSpawnKiller == true && dontSpawnShark == true)
            {
                int val = Random.Range(0, whales.Length);

                if (val == 2)
                {
                    val -= 1;
                }

                if (val == 3)
                {
                    val -= 2;
                }

                Instantiate(whales[val], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
            else if (dontSpawnBlue == true && dontSpawnKiller == true)
            {
                int val = Random.Range(0, whales.Length);

                if (val == 0)
                {
                    val += 1;
                }

                if (val == 2)
                {
                    val += 1;
                }

                Instantiate(whales[val], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
            else if (dontSpawnBlue == true && dontSpawnNarwhal == true && dontSpawnKiller == true)
            {
                int val = Random.Range(0, whales.Length);

                if (val == 0)
                {
                    val += 3;
                }

                if (val == 1)
                {
                    val += 2;
                }
                if (val == 2)
                {
                    val += 1;
                }

                Instantiate(whales[val], transform.position, transform.rotation);
                timer = timeToSpawn;
            }
            else if (dontSpawnBlue == true && dontSpawnNarwhal == true && dontSpawnKiller == true && dontSpawnShark == true)
            {
                timer = timeToSpawn;
            }
            else if (pleaseStop == true)
            {
                timer = timeToSpawn;
            }
            else
            {
                Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
                timer = timeToSpawn;
            }*/
        }
    }

    public void BlueCreate()
    {
        if (dontSpawnBlue == true)
        {
            Instantiate(whales[Random.Range(1, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnShark == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 3)
            {
                val -= 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
    }

    public void NarCreate()
    {
        if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnBlue == true)
        {
            Instantiate(whales[Random.Range(1, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnShark == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 3)
            {
                val -= 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
    }

    public void KillerCreate()
    {
        if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnBlue == true)
        {
            Instantiate(whales[Random.Range(1, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnShark == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 3)
            {
                val -= 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
    }

    public void SharkCreate()
    {
        if (dontSpawnShark == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 3)
            {
                val -= 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Instantiate(whales[val], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnBlue == true)
        {
            Instantiate(whales[Random.Range(1, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
            timer = timeToSpawn;
        }
    }

    public void WhaleCount()
    {
        blueWhales = GameObject.FindGameObjectsWithTag("BlueWhale").Length;
        narWhals = GameObject.FindGameObjectsWithTag("Narwhal").Length;
        sharkWhales = GameObject.FindGameObjectsWithTag("SharkWhale").Length;
        killerWhales = GameObject.FindGameObjectsWithTag("KillerWhale").Length;

        all = blueWhales + narWhals + sharkWhales + killerWhales;

        if (blueWhales >= 2)
        {
            beginning = false;
            dontSpawnBlue = true;
        }
        if (narWhals >= 3)
        {
            beginning = false;
            dontSpawnNarwhal = true;
        }
        if (killerWhales >= 3)
        {
            beginning = false;
            dontSpawnKiller = true;
        }
        if (sharkWhales >= 1)
        {
            beginning = false;
            dontSpawnShark = true;
        }
        if (all <= 15)
        {
            beginning = false;
            pleaseStop = true;
        }
    }
}
