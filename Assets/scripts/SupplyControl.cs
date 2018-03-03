using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupplyControl : MonoBehaviour {

	public float gas=1;
	public float minX, minY, maxX, maxY;
	public Vector2 Speed;
	private SpriteRenderer render;
	public float StandardSpeed = 0.01f;
	// Use this for initialization
	void Start () {
		render = GetComponent<SpriteRenderer>();
		render.color = new Color(Random.value / 2 + 0.5f, Random.value / 2 + 0.5f, Random.value / 2 + 0.5f);
		Speed.x = (maxX - minX) * Random.value + minX - transform.position.x;
		Speed.y = (maxY - minY) * Random.value + minY - transform.position.y;
		Speed *= StandardSpeed;
		GetComponent<Rigidbody2D>().velocity = Speed;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < minX || transform.position.x > maxX || transform.position.y < minY || transform.position.y > maxY)
		{
			Destroy(this.gameObject);
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log(transform.position.x + " " + transform.position.y);
		if (collision.gameObject.tag == "Balloon")
		{
			collision.gameObject.GetComponent<BalloonHealth>().gas_subtract(gas);
			Destroy(this.gameObject);
		}
	}
}
