using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonHealth : MonoBehaviour {

	public float gas;
	public float leak_time = 0.3f, leak_v, leak_v1 = 0.3f, leak_v2 = 20;
	public bool isleak;
	public int outofcontrol;
	private Rigidbody2D body;
	// Use this for initialization
	void Start ()
	{
		gas = 100.0f;
		body = GetComponent<Rigidbody2D>();
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
		transform.localScale = new Vector3(Mathf.Pow(gas / 100.0f,0.4f), Mathf.Pow(gas/100.0f,0.4f), 0);
		body.mass = 0.5f + gas * 0.005f;
		if (isleak)
		{
			gas_subtract(-leak_v*Time.deltaTime/leak_time);
		}

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