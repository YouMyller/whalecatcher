using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WhaleQuota : MonoBehaviour {

    public int whaleCount;

    public Text whaleCountUI;
    public Text deathMeterUI;

    public Image deathBar;

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
        //deathMeterUI.text = (ratio * 100).ToString() + "%";
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "NullBlue")
        {
            whaleCount += 1;
            deathMeter += 20;
            whaleCountUI.text = whaleCount.ToString();
        }

        if (collision.gameObject.tag == "NullKiller")
        {
            whaleCount += 1;
            deathMeter += 10;
            whaleCountUI.text = whaleCount.ToString();
        }

        if (collision.gameObject.tag == "NullNar")
        {
            whaleCount += 1;
            deathMeter += 5;
            whaleCountUI.text = whaleCount.ToString();
        }

        if (collision.gameObject.tag == "NullShark")
        {
            deathMeter -= 10;
            whaleCountUI.text = whaleCount.ToString();
        }
    }
}
