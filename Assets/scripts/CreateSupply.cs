using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSupply : MonoBehaviour {


	public float CreateNumberPS = 10;
	public GameObject supply;
	private float relativeTime = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		relativeTime -= Time.deltaTime;
		while (relativeTime < 0)
		{
			GameObject.Instantiate(supply,transform.position,transform.rotation,transform);
			relativeTime += 1.0f / CreateNumberPS;
		}
	}
}
