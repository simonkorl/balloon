using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHealth : MonoBehaviour {

	public float gas;
	public float leak_time = 0.3f, leak_v, leak_v1 = 0.3f, leak_v2 = 20;
	public bool isleak;
	public int outofcontrol;
	// Use this for initialization
	void Start ()
	{
		gas = 100.0f;
	}

	void stopleak()
	{
		isleak = false;
		outofcontrol--;
	}

	public void leak()
	{
		isleak = true;
		outofcontrol++;
		leak_v = leak_v1 * gas + leak_v2;
		Invoke("stopleak", leak_time);
	}

	// Update is called once per frame
	void Update ()
	{
		if (isleak)
		{
			gas_subtract(-leak_v*Time.deltaTime/leak_time);
		}
		transform.localScale = new Vector3(Mathf.Pow(gas / 100.0f,0.3f), Mathf.Pow(gas/100.0f,0.3f), 0);
	}

	private void die()
	{
		Destroy(this.gameObject);
	}
	public void gas_subtract(float delta)
	{
		gas += delta;
		if (gas < 0)
			die();
	}
}