using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrapper : MonoBehaviour
{
	private float left = Screen.width;
	private float right = Screen.width;
	private float bottom = Screen.height;
	private float top = Screen.height;
	private float buffer = 0.5f;
	private Camera cam;
	private float zDist;
	
	private void Start()
    {
		cam = Camera.main;
		zDist = Mathf.Abs(cam.transform.position.z + transform.position.z);
		left = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, zDist)).x;
		right = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, zDist)).x;
		bottom = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, zDist)).y;
		top = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, zDist)).y;
    }

    private void FixedUpdate()
    {
	    if (transform.position.x < left - buffer)
	    {
		    Debug.Log("Left");
		    transform.position = new Vector3(right, transform.position.y, transform.position.z);
	    }
	    if (transform.position.x > right + buffer)
	    {
		    Debug.Log("Right");
		    transform.position = new Vector3(left, transform.position.y, transform.position.z);
	    }
	    if (transform.position.y < bottom - buffer)
	    {
		    Debug.Log("Bottom");
		    transform.position = new Vector3(transform.position.x, top, transform.position.z);
	    }
	    if (transform.position.y > top + buffer)
	    {
		    Debug.Log("Top");
		    transform.position = new Vector3(transform.position.x, bottom, transform.position.z);
	    }
    }
}
