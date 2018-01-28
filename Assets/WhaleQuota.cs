using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WhaleQuota : MonoBehaviour {

    public int whaleCount;
    private int whalesNumber;

    public Text whaleCountUI;
    public Text deathMeterUI;
    public Text endPointsUI;
    public Text whalezUI;

    public Image deathBar;
    public GameObject gameOver;
    public GameObject endPoints;
    public GameObject whalez;

    public float deathMeterMax;
    public float deathMeter;

    // Use this for initialization
    void Start ()
    {
        deathMeter = deathMeterMax;
        whaleCount = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float ratio = deathMeter / deathMeterMax;

        deathMeter -= Time.deltaTime;

        deathBar.rectTransform.localScale = new Vector3(ratio, 1, 1);

        if (deathMeter <= 0)
        {
            Destroy(whaleCountUI);
            Destroy(deathMeterUI);

            gameOver.SetActive(true);
            endPoints.SetActive(true);
            whalez.SetActive(true);

            endPointsUI.text = ("Total points: " + whaleCount.ToString());
            whalezUI.text = ("Total individual whales: " + whalesNumber.ToString());
        }
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NullBlue")
        {
            whaleCount += 1000;
            deathMeter += 20;
            whalesNumber += 1;

            whaleCountUI.text = whaleCount.ToString();
        }

        if (collision.gameObject.tag == "NullKiller")
        {
            whaleCount += 200;
            deathMeter += 10;
            whalesNumber += 1;

            whaleCountUI.text = whaleCount.ToString();
        }

        if (collision.gameObject.tag == "NullNar")
        {
            whaleCount += 500;
            deathMeter += 5;
            whalesNumber += 1;

            whaleCountUI.text = whaleCount.ToString();
        }

        /*if (collision.gameObject.tag == "NullShark")
        {
            deathMeter -= 10;
            whaleCountUI.text = whaleCount.ToString();
            Debug.Log("Points: " + whaleCount);
        }*/
    }
}
