using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

	
	void Start () {
		
	} // Start
	
	
	void Update () {
		
	} // Update

    private void OnCollisionEnter(Collision collision)
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
} // Class
