using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gyroControl : MonoBehaviour {

	// Use this for initialization

	private bool gyroEnabled;
	private Gyroscope gyro;

	private GameObject cameraContainer;
	private Quaternion rot;


	void Start () {

		cameraContainer = new GameObject("Camera COntainer")
		gyroEnabled = EnableGyro()
	}
	
	// Update is called once per frame
	void Update () {
		gyro.attitude
	}

	private bool EnableGyro()
	{
		if (SystemInfo.supportsGyroscope)
		{
			gyro = Input.gyro;
			gyro.enabled = true;
			return true;
		}

		return false;
	}
}
