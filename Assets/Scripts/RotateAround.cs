using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

	private Vector3 point, axis;
	private float angle;

	// Use this for initialization
	void Start () {
		point = Vector3.zero;
		axis = Vector3.up;
		angle = 200 * Time.deltaTime;

	}

	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (point, axis, angle);	
	}
}
