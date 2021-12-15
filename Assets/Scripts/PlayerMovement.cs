using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private float movementSpeed = 5.5f;
	
	void Update()
    {
	    if (Input.GetAxis("Horizontal") < 0)
	    {
		    transform.position += Vector3.left * movementSpeed * Time.deltaTime;
	    }
        else if (Input.GetAxis("Horizontal") > 0)
	    {
		    transform.position += Vector3.right * movementSpeed * Time.deltaTime;
	    }

	    if (Input.GetAxis("Vertical") < 0)
	    {
		    transform.position += Vector3.down * movementSpeed * Time.deltaTime;
	    }
	    else if (Input.GetAxis("Vertical") > 0)
	    {
		    transform.position += Vector3.up * movementSpeed * Time.deltaTime;
	    }
    }
}
