﻿using UnityEngine;
using System.Collections;

public class FlipRotation : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0, 360 * Time.deltaTime, 0));
	}
}
