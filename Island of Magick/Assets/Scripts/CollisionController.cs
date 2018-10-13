using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour {

    public GameObject exp2 = null;

    private AudioSource[] sounds = null;

    void Start () {

        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();

    } // Start
	
	
	void Update () {
		
	} // Update

    private void OnCollisionEnter(Collision collision)
    {
        this.sounds[4].Play();
        GameObject explosion2 = Instantiate(this.exp2, this.GetComponent<Transform>().position, Quaternion.identity);
        Destroy(explosion2, 8f);
        Destroy(gameObject);
    }

} // Class
