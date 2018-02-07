﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public float rotateSpeed = 30.0f;
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up, rotateSpeed*Time.deltaTime);
	}
}
