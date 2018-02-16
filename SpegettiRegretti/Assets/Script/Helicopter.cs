using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x + 10f, transform.position.y + .1f, transform.position.z + 30f);
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y + 100f, transform.eulerAngles.z);
 
    }
}
