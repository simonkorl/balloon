using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class stats : MonoBehaviour {

	public int numofsupply = 0;
	private Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = 1.0 / Time.deltaTime + "FPS" + Environment.NewLine + numofsupply;
	}
}
