﻿using UnityEngine;
using System.Collections;

public class Parallaxing : MonoBehaviour {

	public Transform[] backgrounds; 
	private float[] parallaxScales; 
	public float smoothing = 1f;

	private Transform cam;
	private Vector3 previousCamPos;

	//is called before Start()
	void Awake () {
		// set up camera the reference 
		cam = Camera.main.transform;
	
	}


	// Use this for initialization
	void Start () {
		// The Prevoious frame had the current frame's camera position
		previousCamPos = cam.position;

		parallaxScales = new float[backgrounds.Length]; 

		for (int i = 0; i < backgrounds.Length; i++ )  {
			parallaxScales[i] = backgrounds[i].position.z*-1; 

		}

	}
	
	// Update is called once per frame
	void Update () {
		// for each background 
		for (int i = 0; i <backgrounds.Length; i++) {
			// the Parallax is the opposite of the camera movement because the previous frame multiplied by the Scale
			float parallax = (previousCamPos.x - cam.position.x) * parallaxScales[i];

			// set a target x position which is the current position plus the parallax 
			float backgroundTargetPosX = backgrounds[i].position.x + parallax;

			//create a target position which is the background's  current position witch it's target x postion 
			Vector3 backgroundTargetPos = new Vector3 (backgroundTargetPosX, backgrounds[i].position.y, backgrounds[i].position.z);

			// fade between target position and the target position using lerp
			backgrounds[i].position = Vector3.Lerp (backgrounds[i].position, backgroundTargetPos, smoothing * Time.deltaTime);

		}

		// set the previousCamPos to the camera's position at the end of the frame 
		previousCamPos = cam.position;
	
	}
}
