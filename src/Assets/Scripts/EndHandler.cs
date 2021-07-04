using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndHandler : MonoBehaviour {
	GameObject ec;
	void OnControllerColliderHit(ControllerColliderHit controllerColliderHit)
    {
		if(controllerColliderHit.transform.name == "Plateforme arrivée")
        {
			ec.SetActive(true);
			gameObject.SetActive(false);
		}
    }


	// Use this for initialization
	void Start () {
		ec = GameObject.Find("EndCamera");
		ec.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
