using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceController : MonoBehaviour {

    private AudioSource[] sounds = null;


    void Start () {
        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();
    } 
	
	void Update () {
		
	} 

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Monster") {
            this.sounds[5].Play();
        }
    } 

} 
