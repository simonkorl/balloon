using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHealth : MonoBehaviour {

	public float gas;
	// Use this for initialization
	void Start ()
	{
		gas = 100.0f;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	private void die()
	{
		Destroy(this);
	}
	public void gas_subtract(float delta)
	{
		gas -= delta;
		if (gas < 0)
			die();
	}
}