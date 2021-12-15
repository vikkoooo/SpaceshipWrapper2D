using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ScreenWrapper : MonoBehaviour
{
	// Screen wrapping
	private float left = Screen.width;
	private float right = Screen.width;
	private float bottom = Screen.height;
	private float top = Screen.height;
	private float buffer = 0.5f;
	private Camera cam;
	private float zDist;

	// Events
	private UnityEvent myEvent;
	
	private void Start()
    {
	    // Screen wrapping
	    cam = Camera.main;
		zDist = Mathf.Abs(cam.transform.position.z + transform.position.z);
		left = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, zDist)).x;
		right = cam.ScreenToWorldPoint(new Vector3(Screen.width, 0.0f, zDist)).x;
		bottom = cam.ScreenToWorldPoint(new Vector3(0.0f, 0.0f, zDist)).y;
		top = cam.ScreenToWorldPoint(new Vector3(0.0f, Screen.height, zDist)).y;
		
		// Events
		myEvent = new UnityEvent();
		myEvent.AddListener(ListeningToEvent);
    }

    private void FixedUpdate()
    {
	    if (transform.position.x < left - buffer)
	    {
		    transform.position = new Vector3(right, transform.position.y, transform.position.z);
		    myEvent.Invoke();
	    }
	    if (transform.position.x > right + buffer)
	    {
		    transform.position = new Vector3(left, transform.position.y, transform.position.z);
		    myEvent.Invoke();
	    }
	    if (transform.position.y < bottom - buffer)
	    {
		    transform.position = new Vector3(transform.position.x, top, transform.position.z);
		    myEvent.Invoke();
	    }
	    if (transform.position.y > top + buffer)
	    {
		    transform.position = new Vector3(transform.position.x, bottom, transform.position.z);
		    myEvent.Invoke();
	    }
    }

    private void ListeningToEvent()
    {
	    Debug.Log("Player out of bounds");
    }
    
}
