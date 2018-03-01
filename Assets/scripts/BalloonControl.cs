using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonControl : MonoBehaviour {

	public float Force = 100;
	public float gasSpeed=0.02f, gasMinSpeed=1;
	private Rigidbody2D body;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	}
	void FixedUpdate()
	{
		Vector2 delta;
		delta.x = (Input.mousePosition.x - Screen.width / 2.0f) * 10.0f / Screen.height - transform.position.x;
		delta.y = (Input.mousePosition.y - Screen.height / 2.0f) * 10.0f / Screen.height - transform.position.y;
		float angle = Mathf.Atan2(delta.y, delta.x) * 180 / Mathf.PI - 90;
		//Debug.Log(Input.mousePosition.x + " " + Input.mousePosition.y);
		if (angle < 0)
			angle += 360;
		transform.eulerAngles = new Vector3(0, 0, angle);
		if (Input.GetMouseButton(0))
		{
			 
			delta.Normalize();
			float gas = GetComponent<BalloonHealth>().gas;
			gas = (gasSpeed * gas + gasMinSpeed)*Time.deltaTime;
			body.AddForce(new Vector2(Force * gas * delta.x, Force * gas * delta.y));
			GetComponent<BalloonHealth>().gas_subtract(gas);
		}
	}
}
