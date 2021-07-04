using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformsScript : MonoBehaviour {
	public Vector3 move;
	public float move_time = 8;
	float time = 0;
	bool reverse = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (time >= move_time)
		{
			if (!reverse)
			{
				reverse = true;
			}
			else
			{
				reverse = false;
			}
			time = 0;
		}
		if (!reverse)
        {
			gameObject.transform.position += move * Time.deltaTime;
		} else
        {
			gameObject.transform.position -= move * Time.deltaTime;
		}
		time += Time.deltaTime;
	}
}
