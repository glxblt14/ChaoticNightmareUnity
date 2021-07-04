using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityStandardAssets.Characters.FirstPerson;

public class NightmareHandler : MonoBehaviour {
	GameObject fpc;
	GameObject background_sound;
	GameObject nightmare_video;

	AudioSource bgaud;
	VideoPlayer vp;

	// Use this for initialization
	void Start()
	{
		fpc = GameObject.Find("FPSController");
		background_sound = GameObject.Find("BackgroundSound");
		nightmare_video = GameObject.Find("NightmareVideo");

		bgaud = background_sound.GetComponent<AudioSource>();
		vp = nightmare_video.GetComponent<VideoPlayer>();
	}

	// Update is called once per frame
	void Update()
	{
        if (fpc.transform.position.y < -100)
		{
			bgaud.Stop();
			vp.Play();
		}
		if ((int)vp.frame == (int)vp.frameCount && (int)vp.frameCount != 0)
		{
			fpc.transform.position = new Vector3(2, 1.5f, 2);
			vp.Stop();
			bgaud.Play();
		}
	}
}
