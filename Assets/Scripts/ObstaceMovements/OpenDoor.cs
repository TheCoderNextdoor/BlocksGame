using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

	public moveLaterally m1;
	public moveLaterally m2;

	// Use this for initialization
	void OnTriggerEnter ()
	{
		m1.enabled = true;
		m2.enabled = true;
	}
}
	