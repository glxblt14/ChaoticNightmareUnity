using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltedPlatformsHandler : MonoBehaviour {
	Dictionary<string, Vector3> tilted_platforms = new Dictionary<string, Vector3>
	{
		{"Plateforme 5 (Tilted)", new Vector3(0.35f, 0, 0)},
		{"Plateforme 6 (Tilted)", new Vector3(-0.35f, 0, 0)},
		{"Plateforme 9 (Tilted)", new Vector3(0, 0, 0.35f)},
		{"Plateforme 12 (Tilted)", new Vector3(0, 0, 0.35f)}

	};

	void OnControllerColliderHit(ControllerColliderHit controllerColliderHit)
	{
		string name = controllerColliderHit.transform.name;
		if (tilted_platforms.ContainsKey(name))
		{
			gameObject.transform.position += tilted_platforms[name] * Time.deltaTime;

		}
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
