using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPlatformsScript : MonoBehaviour {
	bool is_fading = true;
	bool wait = true;
	float wait_time = 3.5f;
	float timer = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (!wait)
		{
			float current_opacity = gameObject.GetComponent<Renderer>().material.color.a;
			float new_opacity;
			float fade_speed = 0.35f * Time.deltaTime;
			if (is_fading)
			{
				new_opacity = current_opacity - fade_speed;
			}
			else
			{
				new_opacity = current_opacity + fade_speed;
			}
			gameObject.GetComponent<Renderer>().material.color = new Vector4(0, 0, 0, new_opacity);
			if (new_opacity >= 1)
			{
				gameObject.GetComponent<BoxCollider>().enabled = true;
				is_fading = true;
				wait = true;
			}
			if(new_opacity > 0.70f && new_opacity < 0.72f)
            {
				gameObject.GetComponent<BoxCollider>().enabled = false;
			}
			if (new_opacity <= 0)
			{
				is_fading = false;
				wait = true;
			}
		} else
        {
			timer += Time.deltaTime;
			if(timer > wait_time)
            {
				timer -= wait_time;
				wait = false;
			}
        }
	}
}
