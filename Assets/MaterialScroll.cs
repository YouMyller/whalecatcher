using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialScroll : MonoBehaviour {

    Renderer meshRen;

    public float scrollSpeed;

	// Use this for initialization
	void Start ()
    {
        meshRen = gameObject.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float offset = Time.time * scrollSpeed;

        meshRen.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
	}
}
