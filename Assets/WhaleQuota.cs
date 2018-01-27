using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhaleQuota : MonoBehaviour {

    public int whaleCount;

    public Text whaleCountUI;
    //public Text deathMeterUI;

    private float deathMeter;

	// Use this for initialization
	void Start ()
    {
        deathMeter = 20;
        whaleCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Mittari alkaa sadasta ja lähtee vähitellen laskemaan ajan kanssa. Joka kerta kun nappaat valaan, mittari saa vähän takaisin (mitä isompi valas, sen enemmän).
        //Joka napatusta valaasta saa pisteen. Peli päättyy, kun mittari menee nollille. Game Over -screenissä näkyy napattujen valaiden määrä (pisteet).
        deathMeter -= Time.deltaTime;
        

	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Null")
        {
            whaleCount += 1;
            whaleCountUI.text = whaleCount.ToString();
        }
    }
}
