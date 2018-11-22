using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour {

	void OnCollisionEnter (Collision collision){
		Destroy(gameObject);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
