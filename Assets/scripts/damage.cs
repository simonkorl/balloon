﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.tag == "Balloon")
		{
			collision.gameObject.GetComponent<BalloonHealth>().leak();
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}