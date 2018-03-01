using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


	// Use this for initialization
	public float minX, minY, maxX, maxY;
	private Transform myBalloon;
	void Start () {
		myBalloon = GameObject.Find("MyBalloon").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(Mathf.Clamp(myBalloon.position.x,minX,maxX),Mathf.Clamp( myBalloon.position.y,minY,maxY),transform.position.z);
	}
}
