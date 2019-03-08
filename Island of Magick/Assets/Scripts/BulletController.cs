using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public GameObject bullet = null;
    public GameObject explosion = null;

    public float force = 100f;
    private AudioSource[] sounds = null;


    void Start () {
        this.sounds = GameObject.Find("AudioController").GetComponents<AudioSource>();
    } 
	
	void Update () {
		if (Input.GetButtonUp("Fire1")) {
            this.sounds[2].Play();
            Invoke("PlayShellSound", 1f);
            GameObject exp = Instantiate(this.explosion, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(exp, 5f);
            GameObject ammo = Instantiate(this.bullet, this.GetComponent<Transform>().position, Quaternion.identity);
            ammo.name = "killer";
            ammo.GetComponent<Rigidbody>().AddForce(this.GetComponent<Transform>().forward * this.force);
            Destroy(ammo, 20f);
        }
    }

    void PlayShellSound() {
        this.sounds[3].Play();
    }

} 
