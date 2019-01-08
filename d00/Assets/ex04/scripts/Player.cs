using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public 	GameObject    	player;
	public	string			key1;
	public	string			key2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(key1)){
			if (player.transform.localPosition.y < 4){
				player.transform.Translate(Vector3.up * 0.5f);
			}
		}
		else if (Input.GetKey(key2)){
			if (player.transform.localPosition.y > -4){
				player.transform.Translate(Vector3.down * 0.5f);
			}
		}
	}
}
