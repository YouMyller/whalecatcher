﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Randomizer : MonoBehaviour {

    public float timer;
    public float timeToSpawn;

    public Transform[] spawnPoints;

    public GameObject[] whales;
    public int blueWhales;
    public int narWhals;
    public int killerWhales;
    public int all;

    private bool beginning = true;
    private bool dontSpawnBlue = false;
    private bool dontSpawnNarwhal = false;
    private bool dontSpawnKiller = false;
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
                //Instantiate(whales[Random.Range(0, whales.Length)], transform.position, transform.rotation);
                Transform spawn = spawnPoints[Random.Range(0,spawnPoints.Length)];
                Instantiate(whales[Random.Range(0, whales.Length)], spawn.position, spawn.rotation);
                Debug.Log(spawn);
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
            }
        }
    }

    public void BlueCreate()
    {
        if (dontSpawnBlue == true)
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(1, whales.Length)], spawn.position, spawn.rotation);

            timer = timeToSpawn;
        }
        else if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val -= 1;
            }

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(0, whales.Length)], spawn.position, spawn.rotation);

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

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnBlue == true)
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(1, whales.Length)], spawn.position, spawn.rotation);

            timer = timeToSpawn;
        }
        else if (dontSpawnKiller == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 2)
            {
                val -= 1;
            }

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(0, whales.Length)], spawn.position, spawn.rotation);

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
                val -= 1;
            }

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnNarwhal == true)
        {
            int val = Random.Range(0, whales.Length);

            if (val == 1)
            {
                val += 1;
            }

            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];

            Instantiate(whales[val], spawn.position, spawn.rotation);
            timer = timeToSpawn;
        }
        else if (dontSpawnBlue == true)
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(1, whales.Length)], spawn.position, spawn.rotation);

            timer = timeToSpawn;
        }
        else
        {
            Transform spawn = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(whales[Random.Range(0, whales.Length)], spawn.position, spawn.rotation);

            timer = timeToSpawn;
        }
    }


    public void WhaleCount()
    {
        blueWhales = GameObject.FindGameObjectsWithTag("BlueWhale").Length;
        narWhals = GameObject.FindGameObjectsWithTag("Narwhal").Length;
        killerWhales = GameObject.FindGameObjectsWithTag("KillerWhale").Length;

        all = blueWhales + narWhals + killerWhales;

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
        if (all <= 15)
        {
            beginning = false;
            pleaseStop = true;
        }
    }
}
