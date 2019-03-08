using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour {

    public GameObject exp3 = null;
    private GameObject score = null;
    private int hits = 0;


    void Start () {
        this.score = GameObject.Find("Player");
	} 
	
	void Update () {
        if(hits >= 3) {
            GameObject explosion = Instantiate(this.exp3, this.GetComponent<Transform>().position, Quaternion.identity);
            Destroy(explosion, 8f);
            Destroy(this.gameObject);
            this.score.GetComponent<PointsCounter>().score += 1;
        } 
		
	} 

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.name == "killer") {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            hits += 1;
        }    
    } 

} 
