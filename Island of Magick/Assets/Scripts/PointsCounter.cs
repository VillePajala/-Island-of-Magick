using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsCounter : MonoBehaviour {

    public GameObject big_monster = null;
    private GameObject kills = null;
    public int score = 0;
	

	void Start () {
        this.kills = GameObject.Find("Points");
	} 
	
	
	void Update () {
        if (score <= 9) {
            this.kills.GetComponent<Text>().text = "Monsters killed: " + score + "/9";
        } 
        
        if (score == 9) {
            Quaternion form = new Quaternion(0f, 45f, 45f, 0f);
            GameObject monster = Instantiate(this.big_monster, new Vector3(600f, 500f, 600f), form);
            score += 1;
            this.kills.GetComponent<Text>().text = "Monsters killed: 9/9";
        }
    } 

} 
