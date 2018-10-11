using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public Transform target;
	public Vector3 offset;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
			Vector3 desiredPosition = new Vector3(target.position.x, 0, target.position.z) + offset;
			transform.position = desiredPosition;	
	}

}
